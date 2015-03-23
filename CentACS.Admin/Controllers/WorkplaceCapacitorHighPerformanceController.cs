using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CentACS.Admin.Data;

namespace CentACS.Admin.Controllers
{
    public class WorkplaceCapacitorHighPerformanceController : Controller
    {
        #region [ Repository ]
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();
        #endregion

        // GET: WorkplaceCapacitorHighPerformance
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageCapacitorHighPerformance.ToListAsync());
        }

        // GET: WorkplaceCapacitorHighPerformance/Details/5
        public async Task<ActionResult> Details(int? languageKey)
        {
            if (languageKey == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            tblWorkplace_LanguageCapacitorHighPerformance tblWorkplace_LanguageCapacitorHighPerformance = await db.tblWorkplace_LanguageCapacitorHighPerformance.Where(I => I.LanguageKey == languageKey).FirstAsync();
            if (tblWorkplace_LanguageCapacitorHighPerformance == null)
            {
                return HttpNotFound();
            }

            return View(tblWorkplace_LanguageCapacitorHighPerformance);
        }

        // GET: WorkplaceCapacitorHighPerformance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkplaceCapacitorHighPerformance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CapacitorHighPerfKey,LanguageKey,HighPerfStrategy,Text")] tblWorkplace_LanguageCapacitorHighPerformance tblWorkplace_LanguageCapacitorHighPerformance)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageCapacitorHighPerformance.Add(tblWorkplace_LanguageCapacitorHighPerformance);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageCapacitorHighPerformance);
        }

        // GET: WorkplaceCapacitorHighPerformance/Edit/5
        public async Task<ActionResult> Edit(int? languageKey)
        {
            tblWorkplace_LanguageCapacitorHighPerformance model = new tblWorkplace_LanguageCapacitorHighPerformance();

            if (languageKey == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // Check Results 
            var results = await db.tblWorkplace_LanguageCapacitorHighPerformance.Where(l => l.LanguageKey == languageKey).ToListAsync();

            if (results.Any()) 
            {
                model = results.First();
                return View(model);
            }

            return RedirectToAction("Create", model);
        }

        // POST: WorkplaceCapacitorHighPerformance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CapacitorHighPerfKey,LanguageKey,HighPerfStrategy,Text")] tblWorkplace_LanguageCapacitorHighPerformance tblWorkplace_LanguageCapacitorHighPerformance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageCapacitorHighPerformance).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageCapacitorHighPerformance);
        }

        // GET: WorkplaceCapacitorHighPerformance/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorHighPerformance tblWorkplace_LanguageCapacitorHighPerformance = await db.tblWorkplace_LanguageCapacitorHighPerformance.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorHighPerformance == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorHighPerformance);
        }

        // POST: WorkplaceCapacitorHighPerformance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageCapacitorHighPerformance tblWorkplace_LanguageCapacitorHighPerformance = await db.tblWorkplace_LanguageCapacitorHighPerformance.FindAsync(id);
            db.tblWorkplace_LanguageCapacitorHighPerformance.Remove(tblWorkplace_LanguageCapacitorHighPerformance);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
