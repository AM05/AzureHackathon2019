using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MatcHWebMVC.Data;
using MatcHWebMVCC.Models;

namespace MatcHWebMVCC.Controllers
{
	public class IBMBaselineController : Controller
    {
        private readonly MatcHCloudContext _context;

        public IBMBaselineController(MatcHCloudContext context)
        {
            _context = context;
        }

        // GET: IBMBaseline
        public async Task<IActionResult> Index()
        {
			//List<IBMBaseline> IBM_BASELINE = new List<IBMBaseline>();
			//IBM_BASELINE = (from IBMBaseline in _context.IBMBaseline select IBMBaseline).ToList();
			//return View(IBM_BASELINE.ToList());
			return View(await _context.IBMBaseline.ToListAsync());			
		}

        // GET: IBMBaseline/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iBMBaseline = await _context.IBMBaseline
                .SingleOrDefaultAsync(m => m.BASELINEID == id);
            if (iBMBaseline == null)
            {
                return NotFound();
            }

            return View(iBMBaseline);
        }

        // GET: IBMBaseline/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IBMBaseline/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BASELINEID,MAI,RP_CI_Name,RP_Environment,PLATFORM,VERSION,OAR_ID,DOMAIN_IT_PRODUCT,DOMAIN_OAR,SUB_DOMAIN,ADM_VENDOR,MAINT_VENDOR,IT_PRODUCT_ID,IT_PRODUCT,IT_BUSINESS_SERVICE,CIA_RATING_IT_PRODUCT,CIA_RATING_OAR,RP_CI_STATUS,PLANNING,ACTION,SUB_ACTION,MATCH_WAVE,MATCH_DATE,MATCH_PHASE,CLEAN_SOURCE,CLEAN_DATE,CLEAN_PHASE,CLEAN_ID,HISTORY,STATUS_IT_PRODUCT,PRIMARY_CI_NAME,ADDRESS_OF_CI,LOGICAL_CI_AD_DOMAIN,IP_ADDRESS,MATCH_VENDOR,CIA,PHYSICAL_SERVER_NAME,PHYSICAL_CI_NAME,BUSINESS_SERVICE")] IBMBaseline iBMBaseline)
        {
            if (ModelState.IsValid)
            {
                _context.Add(iBMBaseline);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(iBMBaseline);
        }

        // GET: IBMBaseline/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iBMBaseline = await _context.IBMBaseline.SingleOrDefaultAsync(m => m.BASELINEID == id);
            if (iBMBaseline == null)
            {
                return NotFound();
            }
            return View(iBMBaseline);
        }

        // POST: IBMBaseline/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BASELINEID,MAI,RP_CI_Name,RP_Environment,PLATFORM,VERSION,OAR_ID,DOMAIN_IT_PRODUCT,DOMAIN_OAR,SUB_DOMAIN,ADM_VENDOR,MAINT_VENDOR,IT_PRODUCT_ID,IT_PRODUCT,IT_BUSINESS_SERVICE,CIA_RATING_IT_PRODUCT,CIA_RATING_OAR,RP_CI_STATUS,PLANNING,ACTION,SUB_ACTION,MATCH_WAVE,MATCH_DATE,MATCH_PHASE,CLEAN_SOURCE,CLEAN_DATE,CLEAN_PHASE,CLEAN_ID,HISTORY,STATUS_IT_PRODUCT,PRIMARY_CI_NAME,ADDRESS_OF_CI,LOGICAL_CI_AD_DOMAIN,IP_ADDRESS,MATCH_VENDOR,CIA,PHYSICAL_SERVER_NAME,PHYSICAL_CI_NAME,BUSINESS_SERVICE")] IBMBaseline iBMBaseline)
        {
            if (id != iBMBaseline.BASELINEID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(iBMBaseline);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IBMBaselineExists(iBMBaseline.BASELINEID))
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
            return View(iBMBaseline);
        }

        // GET: IBMBaseline/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var iBMBaseline = await _context.IBMBaseline
                .SingleOrDefaultAsync(m => m.BASELINEID == id);
            if (iBMBaseline == null)
            {
                return NotFound();
            }

            return View(iBMBaseline);
        }

        // POST: IBMBaseline/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var iBMBaseline = await _context.IBMBaseline.SingleOrDefaultAsync(m => m.BASELINEID == id);
            _context.IBMBaseline.Remove(iBMBaseline);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IBMBaselineExists(int id)
        {
            return _context.IBMBaseline.Any(e => e.BASELINEID == id);
        }
    }
}
