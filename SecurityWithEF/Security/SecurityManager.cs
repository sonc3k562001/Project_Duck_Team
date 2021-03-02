using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using SecurityWithEF.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;

namespace SecurityWithEF.Security
{
    public class SecurityManager
    {
        public async void SignIn(HttpContext httpContext ,Account account)
        {
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(getAccountClaims(account),CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
        }

        public async void SignOut(HttpContext httpContext)
        {
            await httpContext.SignOutAsync();
        }
        private IEnumerable<Claim> getAccountClaims(Account account)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, account.Username));

            account.AccountRole.ToList().ForEach(ac =>
            {
                claims.Add(new Claim(ClaimTypes.Role, ac.Role.Name)); 
            });
            return claims;
            
        }
    }
}
