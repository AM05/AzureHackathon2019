using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MatcHWebMVC.Data;
using MatcHWebMVC.Models;

namespace MatcHWebMVC.Controllers
{
    public class DCL3Controller : Controller
    {
        private readonly MatcHCloudContext _context;

        public DCL3Controller(MatcHCloudContext context)
        {
            _context = context;
        }

		// GET: DCL3
		public ActionResult Index()
		{
			List<DCL3> DCL3LIST = new List<DCL3>();
			DCL3LIST = (from DCL3 in _context.DCL3 select DCL3).ToList();
			return View(DCL3LIST.ToList());
		}

		// GET: DCL3/Details/5
		public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dCL3 = await _context.DCL3
                .SingleOrDefaultAsync(m => m.DCL3ID == id);
            if (dCL3 == null)
            {
                return NotFound();
            }

            return View(dCL3);
        }

        // GET: DCL3/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DCL3/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DCL3ID,MAI,Wave,DOMAIN,IT_GRID,OAR_ID,PRODUCT_ID,IT_PRODUCT,MATCH_ITPRODUCT,MATCH_VENDOR")] DCL3 dCL3)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dCL3);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dCL3);
        }

        // GET: DCL3/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dCL3 = await _context.DCL3.SingleOrDefaultAsync(m => m.DCL3ID == id);
            if (dCL3 == null)
            {
                return NotFound();
            }
            return View(dCL3);
        }

        // POST: DCL3/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DCL3ID,MAI,Wave,DOMAIN,IT_GRID,OAR_ID,PRODUCT_ID,IT_PRODUCT,MATCH_ITPRODUCT,MATCH_VENDOR")] DCL3 dCL3)
        {
            if (id != dCL3.DCL3ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dCL3);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DCL3Exists(dCL3.DCL3ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(dCL3);
        }

        // GET: DCL3/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dCL3 = await _context.DCL3
                .SingleOrDefaultAsync(m => m.DCL3ID == id);
            if (dCL3 == null)
            {
                return NotFound();
            }

            return View(dCL3);
        }

        // POST: DCL3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dCL3 = await _context.DCL3.SingleOrDefaultAsync(m => m.DCL3ID == id);
            _context.DCL3.Remove(dCL3);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DCL3Exists(int id)
        {
            return _context.DCL3.Any(e => e.DCL3ID == id);
        }
    }
}
