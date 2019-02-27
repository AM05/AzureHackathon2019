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
    public class WAVE_PLANController : Controller
    {
        private readonly MatcHCloudContext _context;

        public WAVE_PLANController(MatcHCloudContext context)
        {
            _context = context;
        }

        // GET: WAVE_PLAN
        public async Task<IActionResult> Index()
        {			
            return View(await _context.WAVE_PLAN.ToListAsync());
        }

        // GET: WAVE_PLAN/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wAVE_PLAN = await _context.WAVE_PLAN
                .SingleOrDefaultAsync(m => m.Wave_Plan_ID == id);
            if (wAVE_PLAN == null)
            {
                return NotFound();
            }

            return View(wAVE_PLAN);
        }

        // GET: WAVE_PLAN/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WAVE_PLAN/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Wave_Plan_ID,MAI,OAR_ID,IT_PRODUCT,CIA_RATING,DOMAIN,WP_4_0,IT_DELIVERY_DOMAIN,IT_PROD_ID,BAU_AD_VENDOR,MATCH_VENDOR")] WAVE_PLAN wAVE_PLAN)
        {
            if (ModelState.IsValid)
            {
                _context.Add(wAVE_PLAN);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(wAVE_PLAN);
        }

        // GET: WAVE_PLAN/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wAVE_PLAN = await _context.WAVE_PLAN.SingleOrDefaultAsync(m => m.Wave_Plan_ID == id);
            if (wAVE_PLAN == null)
            {
                return NotFound();
            }
            return View(wAVE_PLAN);
        }

        // POST: WAVE_PLAN/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Wave_Plan_ID,MAI,OAR_ID,IT_PRODUCT,CIA_RATING,DOMAIN,WP_4_0,IT_DELIVERY_DOMAIN,IT_PROD_ID,BAU_AD_VENDOR,MATCH_VENDOR")] WAVE_PLAN wAVE_PLAN)
        {
            if (id != wAVE_PLAN.Wave_Plan_ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(wAVE_PLAN);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WAVE_PLANExists(wAVE_PLAN.Wave_Plan_ID))
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
            return View(wAVE_PLAN);
        }

        // GET: WAVE_PLAN/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var wAVE_PLAN = await _context.WAVE_PLAN
                .SingleOrDefaultAsync(m => m.Wave_Plan_ID == id);
            if (wAVE_PLAN == null)
            {
                return NotFound();
            }

            return View(wAVE_PLAN);
        }

        // POST: WAVE_PLAN/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var wAVE_PLAN = await _context.WAVE_PLAN.SingleOrDefaultAsync(m => m.Wave_Plan_ID == id);
            _context.WAVE_PLAN.Remove(wAVE_PLAN);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WAVE_PLANExists(int id)
        {
            return _context.WAVE_PLAN.Any(e => e.Wave_Plan_ID == id);
        }
    }
}
