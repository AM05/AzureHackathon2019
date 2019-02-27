﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using MatchLogin;

namespace SimpleLogin.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty] // Bind on Post
        public LoginData loginData { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {			
			clsLogin clsLog = new clsLogin();
			if (ModelState.IsValid)
            {				
                var isValid = (loginData.Username == "username" && loginData.Password == "password"); // TODO Validate the username and the password with your own logic
				bool bLoginCheck = clsLog.LoginCheck(loginData.Username, loginData.Password);
				if (bLoginCheck == true)
				//if (!isValid)
                {
                    ModelState.AddModelError("", "username or password is invalid");                  
                
                // Create the identity from the user info
                var identity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme, ClaimTypes.Name, ClaimTypes.Role);
                identity.AddClaim(new Claim(ClaimTypes.NameIdentifier, loginData.Username));
                identity.AddClaim(new Claim(ClaimTypes.Name, loginData.Username));
                // Authenticate using the identity
                var principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, new AuthenticationProperties { IsPersistent = loginData.RememberMe });
					//return RedirectToPage("Index");
					return RedirectToAction("Index", "http://localhost:54992/Home");
					// return this.RedirectToAction("Index", "Home", new { redirectUrl = url });
					// return RedirectToPage("http://localhost:54992/Home");

				}
				else
				{
					return Page();
				}
			}
            else
            {
                ModelState.AddModelError("", "username or password is blank");
                return Page();
            }
        }

        public class LoginData
        {
            [Required]
            public string Username { get; set; }

            [Required, DataType(DataType.Password)]
            public string Password { get; set; }

            public bool RememberMe { get; set; }
        }
    }
}