using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.ComponentModel.DataAnnotations.Schema;


namespace MatcHWebMVCC.Models
{
    public class Users
    {
			[Key]
			public int USERID { get; set; }

			[Required]
			[Display(Name = "LOGIN NAME")]
			[StringLength(50, MinimumLength = 3)]
			public string LOGIN_NAME { get; set; }

			[Display(Name = "PASSWORD")]
			[StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
			public string PASSWORDS { get; set; }

			public bool RememberMe { get; set; }
		}
}
