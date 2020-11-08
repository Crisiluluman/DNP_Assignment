using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.JSInterop;
using DNP_Assignment.Models;

namespace DNP_Assignment.Data
{
    public class CustomAuthenticatorStateProvider : AuthenticationStateProvider
    {
        private readonly IJSRuntime JsRuntime;
        private readonly ICloudService cloudService;
        private User user;

        private User cachedUser;

        public CustomAuthenticatorStateProvider(IJSRuntime jsRuntime, ICloudService cloudService)
        {
            JsRuntime = jsRuntime;
            this.cloudService = cloudService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();

            if (cachedUser == null)
            {
                string userAsJson = await JsRuntime.InvokeAsync<string>("sessionStorage.getItem", "currentUser");
                if (!string.IsNullOrEmpty(userAsJson))
                {
                    cachedUser = JsonSerializer.Deserialize<User>(userAsJson);

                    identity = SetupClaimsForUser(cachedUser);
                }
            }
            else
            {
                identity = SetupClaimsForUser(cachedUser);
            }
            
            ClaimsPrincipal cachedClaimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult((new AuthenticationState(cachedClaimsPrincipal)));
        }


        public void ValidateLogin(String Username, String Password)
        {/**/
            if (string.IsNullOrEmpty(Username)) throw new Exception("Enter Username");
            if (string.IsNullOrEmpty(Password)) throw new Exception("Enter Password");
            
            ClaimsIdentity identity = new ClaimsIdentity();
            try
            {
                Console.WriteLine("StateProvider " + Username + Password);
                cloudService.validateUser(Username, Password);     // I can't find the mistake..
                // User user = cloudService.validateUser(Username, Password);
                
                // Console.WriteLine("Test 2 " + user.UserName);
                //User user = UserService.ValidateUser(Username, Password);
                identity = SetupClaimsForUser(user);
                string serialisedData = JsonSerializer.Serialize(user);
                JsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", serialisedData);
                cachedUser = user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
            
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(new ClaimsPrincipal(identity))));
        }


        public void LogOut()
        {
            cachedUser = null;
            var user = new ClaimsPrincipal(new ClaimsIdentity());
            JsRuntime.InvokeVoidAsync("sessionStorage.setItem", "currentUser", "");
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }


        private ClaimsIdentity SetupClaimsForUser(User user) {
            List<Claim> claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, user.UserName));
            claims.Add(new Claim("Password", user.Password));
            claims.Add(new Claim("Role", user.Role));
            ClaimsIdentity identity = new ClaimsIdentity(claims, "apiauth_type");
            return identity;
        }

    }
}