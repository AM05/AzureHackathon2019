using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MatcHWebMVC.Models;
using MatcHWebMVC.Data;
using System.Web;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace MatcHWebMVC.Controllers
{
	public class IT_PRODUCTSController : Controller
	{
		private readonly MatcHCloudContext _context;
		
		
		public IT_PRODUCTSController(MatcHCloudContext context)
		{
			_context = context;			
		}

		//public IT_PRODUCTSController(IConfiguration iconfiguration)
		//{
		//	_iconfiguration = iconfiguration;
		//}

		public ActionResult Index()
		{			
			//string value1 = _iconfiguration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
			//string value2 = _iconfiguration.GetValue<string>("ConnectionStrings:DefaultConnection");
			TraceSource source = new TraceSource("IT  PRODUCTSController");
			source.TraceEvent(TraceEventType.Warning, 100, "This is message logged from IT_PRODUCTS Controller");
			Trace.WriteLine("The connectionstring from IT_PRODUCTSController Controller is ");
			List<IT_PRODUCTS> ITPRODLIST = new List<IT_PRODUCTS>();
			ITPRODLIST = (from IT_PRODUCT in _context.IT_PRODUCT select IT_PRODUCT).ToList();
			return View(ITPRODLIST.ToList());
		}

		public ActionResult Details(int? id)
		{			
			if (id == null)
			{
				return NotFound();
			}			

			var itproddet = (from m in _context.IT_PRODUCT where m.ID == id select m).ToList();
			if (itproddet == null)
			{
				return NotFound();
			}

			return View(itproddet);
		}

		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}
			var itproddel = await _context.IT_PRODUCT.SingleOrDefaultAsync(m => m.ID == id);
			_context.IT_PRODUCT.Remove(itproddel);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Edit(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var appcodes = await _context.IT_PRODUCT
				.AsNoTracking()
				.SingleOrDefaultAsync(m => m.ID == id);
			if (appcodes == null)
			{
				return NotFound();
			}
			// PopulateDepartmentsDropDownList(appcodes.MAI);
			return View(appcodes);
		}

		private void PopulateDepartmentsDropDownList(object selectedAppCode = null)
		{
			var appscodeQuery = from d in _context.IT_PRODUCT
								   orderby d.IT_PRODUCT
								   select d;
			ViewBag.DepartmentID = new SelectList(appscodeQuery.AsNoTracking(), "MAI", "IT_PRODUCT", selectedAppCode);
		}

		[HttpPost, ActionName("Edit")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> EditPost(int? id)
			// Not getting updated. Recheck tomorrow.
		{
			if (id == null)
			{
				return NotFound();
			}

			var ITprodToUpdate = await _context.IT_PRODUCT
				.SingleOrDefaultAsync(c => c.ID == id);

			if (await TryUpdateModelAsync<IT_PRODUCTS>(ITprodToUpdate,
				"",
				c => c.MAI, c => c.OAR_ID, c => c.IT_PRODUCT))
			{
				try
				{
					await _context.SaveChangesAsync();
				}
				catch (DbUpdateException /* ex */)
				{
					//Log the error (uncomment ex variable name and write a log.)
					ModelState.AddModelError("", "Unable to save changes. " +
						"Try again, and if the problem persists, " +
						"see your system administrator.");
				}
				return RedirectToAction(nameof(Index));
			}
			// PopulateDepartmentsDropDownList(ITprodToUpdate.ID);
			return View(ITprodToUpdate);

		}
	}
	
}