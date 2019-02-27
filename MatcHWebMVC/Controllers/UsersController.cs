using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MatcHWebMVCC.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
			List<UsersController> userc = new List<UsersController>
			{

			};
			return View();
        }

		public IActionResult Login()
		{
			List<UsersController> userct = new List<UsersController>
			{

			};
			return View();
		}
    }
}