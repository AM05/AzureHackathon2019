using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MatcHWebMVCC.Models;
using MatcHWebMVC.Data;


namespace MatcHWebMVCC.Controllers
{
    public class FirstPageController : Controller
    {
		private readonly MatcHCloudContext _context;

		public FirstPageController(MatcHCloudContext context)
		{
			_context = context;
		}

		public IActionResult Index()
        {			
			FirstPage fp = new FirstPage();
			List<FirstPage> liFP = new List<FirstPage>();
			liFP = fp.GetFirstPage();
			ViewData["FirstPageData"] = liFP;
			return View(liFP.ToList());
			// return View();
        }
		public ActionResult GetFirstPage()
		{
			FirstPage fp = new FirstPage();
			List<FirstPage> liFP = new List<FirstPage>();
			liFP = fp.GetFirstPage();
			ViewData["FirstPageData"] = liFP;
			return View(liFP.ToList());
			// return View();
		}
    }
}