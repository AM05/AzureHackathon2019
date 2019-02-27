using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MatcHWebMVC.Models;
using MatcHWebMVCC.Models;

namespace MatcHWebMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {			
			FirstPage fp = new FirstPage();
			List<FirstPage> liFP = new List<FirstPage>();
			liFP = fp.GetFirstPage();
			ViewData["FirstPageData"] = liFP;
			return View(liFP.ToList());
			// return View();
		}

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
		public IActionResult IT_PRODUCTS()
		{
			ViewData["Message"] = "IT Products in MatcH";
			return View();
		}

		public IActionResult DCL3()
		{
			ViewData["Message"] = "DCL3 in MatcH";
			return View();
		}

		public IActionResult WAVE_PLAN()
		{
			ViewData["Message"] = "WAVE Plan in MatcH";
			return View();
		}

		public ActionResult BootStrapInAction()
		{
			ViewBag.message = "Testing Popup menu Bootstrap";
			return View();
		}

		public ActionResult IBMBaseline()
		{
			ViewData["Message"] = "IBM Baseline in MatcH";
			return View();
		}
		
		public ActionResult INVENTORY()
		{
			ViewData["Message"] = "CI Info in MatcH";
			return View();
		}
		
		public ActionResult PDD_STATUS()
		{
			ViewData["Message"] = "PDD Status in MatcH";
			return View();
		}

		
		public ActionResult Search()
		{
			ViewData["Message"] = "Advanced Search in MatcH";
			return View();
		}

		public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
