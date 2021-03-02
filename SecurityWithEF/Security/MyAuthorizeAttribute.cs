using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using SecurityWithEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace SecurityWithEF.Security
{
    public class MyAuthorizeAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        private MyDBContext db = new MyDBContext();
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var username = getUsername(context.HttpContext.User);
            if (string.IsNullOrEmpty(username))
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "account", Action = "index" }));
            }
            else
            {
                var roles = Roles.Split(new char[] { ',' });
                var account = db.Accounts.SingleOrDefault(a => a.Username.Equals(username));
                var isInRole = account.AccountRole.Any(ar => roles.Contains(ar.Role.Name));

                if (!isInRole)
                {
                    context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { Controller = "account", Action = "accessDenied" }));
                }
            }
        }

        private string getUsername(IPrincipal user)
        {
            var identity =(ClaimsIdentity)user.Identity;
            IEnumerable<Claim> claims = identity.Claims;
            return claims.FirstOrDefault(s => s.Type == ClaimTypes.NameIdentifier)?.Value;
        }
    }
}
