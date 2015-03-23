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
    public class WorkplaceLanguageCapacitorLowPerformanceController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageCapacitorLowPerformance
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageCapacitorLowPerformance.ToListAsync());
        }

        // GET: WorkplaceLanguageCapacitorLowPerformance/Details/5
        public async Task<ActionResult> Details(int? languageKey)
        {
            if (languageKey == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            tblWorkplace_LanguageCapacitorLowPerformance tblWorkplace_LanguageCapacitorLowPerformance = await db.tblWorkplace_LanguageCapacitorLowPerformance.Where(l => l.LanguageKey == languageKey).FirstAsync();

            if (tblWorkplace_LanguageCapacitorLowPerformance == null)
            {
                return HttpNotFound();
            }

            return View(tblWorkplace_LanguageCapacitorLowPerformance);
        }

        // GET: WorkplaceLanguageCapacitorLowPerformance/Create
        public ActionResult Create(Int32 languageKey = 1)
        {
            var model = new tblWorkplace_LanguageCapacitorLowPerformance()
            {
                LanguageKey = languageKey
            };

            return View(model);
        }

        // POST: WorkplaceLanguageCapacitorLowPerformance/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CapacitorLowPerfKey,LanguageKey,LowPerfStrategy,Text")] tblWorkplace_LanguageCapacitorLowPerformance tblWorkplace_LanguageCapacitorLowPerformance)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageCapacitorLowPerformance.Add(tblWorkplace_LanguageCapacitorLowPerformance);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageCapacitorLowPerformance);
        }

        // GET: WorkplaceLanguageCapacitorLowPerformance/Edit/5
        public async Task<ActionResult> Edit(int? languageKey)
        {
            if (languageKey == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var results = await db.tblWorkplace_LanguageCapacitorLowPerformance.Where(l => l.LanguageKey == languageKey).ToListAsync();


            if (results.Any())
            {
                return View(results.First());
            }

            return RedirectToAction("Create", new { languageKey = languageKey});
        }

        // POST: WorkplaceLanguageCapacitorLowPerformance/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CapacitorLowPerfKey,LanguageKey,LowPerfStrategy,Text")] tblWorkplace_LanguageCapacitorLowPerformance tblWorkplace_LanguageCapacitorLowPerformance)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageCapacitorLowPerformance).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageCapacitorLowPerformance);
        }

        // GET: WorkplaceLanguageCapacitorLowPerformance/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorLowPerformance tblWorkplace_LanguageCapacitorLowPerformance = await db.tblWorkplace_LanguageCapacitorLowPerformance.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorLowPerformance == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorLowPerformance);
        }

        // POST: WorkplaceLanguageCapacitorLowPerformance/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageCapacitorLowPerformance tblWorkplace_LanguageCapacitorLowPerformance = await db.tblWorkplace_LanguageCapacitorLowPerformance.FindAsync(id);
            db.tblWorkplace_LanguageCapacitorLowPerformance.Remove(tblWorkplace_LanguageCapacitorLowPerformance);
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
