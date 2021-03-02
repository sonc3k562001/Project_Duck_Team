using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using SecurityInASPNETCore.Models;
using System.Collections.Generic;
using System.Security.Claims;


namespace SecurityInASPNETCore.Security
{
    public class AccountManager
    {
       
        public async void SignIn(HttpContext httpContext,Account account)
        {
            ClaimsIdentity claimsIndentity = new ClaimsIdentity(getUserClaims(account), CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(claimsIndentity);
            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
        }

        public async void SignOut(HttpContext httpContext) 
        {
            await httpContext.SignOutAsync();
        }

        private IEnumerable<Claim> getUserClaims(Account account)
        {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.NameIdentifier, account.Username));
            foreach ( var role in account.Roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }
    }
}
