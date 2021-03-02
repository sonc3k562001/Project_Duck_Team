using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using SecurityInASPNETCore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;


namespace SecurityInASPNETCore.Security
{
    public class MyAuthorizeAttribute : AuthorizeAttribute,IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var username = getUsername(context.HttpContext.User);
            if (string.IsNullOrEmpty(username))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new {controller = "Account",action ="Index"}));
            }
            else
            {
                AccountModel accountModel = new AccountModel();
                var userRoles = accountModel.find(username).Roles;
                var roles = Roles.Split(new char[] { ',' });
                var isInRoles = userRoles.Any(r => roles.Contains(r));
                if(!isInRoles)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Account", action = "AccessDenied" }));
                }
            }
        }
        private string getUsername(IPrincipal user)
        {
            var identity = (ClaimsIdentity)user.Identity;
            IEnumerable<Claim> claims = identity.Claims;
            return claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
