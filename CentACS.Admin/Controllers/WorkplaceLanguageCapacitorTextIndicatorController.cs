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
    public class WorkplaceLanguageCapacitorTextIndicatorController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageCapacitorTextIndicator
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageCapacitorTextIndicator.ToListAsync());
        }

        // GET: WorkplaceLanguageCapacitorTextIndicator/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorTextIndicator tblWorkplace_LanguageCapacitorTextIndicator = await db.tblWorkplace_LanguageCapacitorTextIndicator.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorTextIndicator == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorTextIndicator);
        }

        // GET: WorkplaceLanguageCapacitorTextIndicator/Create
        public ActionResult Create(Int32 LanguageKey = 0)
        {
            var results = new List<tblWorkplace_LanguageCapacitorTextIndicator>();

            results = this.db.tblWorkplace_LanguageCapacitorTextIndicator.ToListAsync().Result;

            return View(results);
        }

        // POST: WorkplaceLanguageCapacitorTextIndicator/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Workplace_CapacitorTextIndicatorKey,CompetencyKey,Source,EnglishCompetencyName,EnglishIndicator,SpanishCompetencyName,SpanishIndicator,GermanCompetencyName,GermanIndicator,ChineseCompetencyName,ChineseIndicator,PortugueseCompetencyName,PortugueseIndicator")] tblWorkplace_LanguageCapacitorTextIndicator tblWorkplace_LanguageCapacitorTextIndicator)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageCapacitorTextIndicator.Add(tblWorkplace_LanguageCapacitorTextIndicator);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageCapacitorTextIndicator);
        }

        // GET: WorkplaceLanguageCapacitorTextIndicator/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorTextIndicator tblWorkplace_LanguageCapacitorTextIndicator = await db.tblWorkplace_LanguageCapacitorTextIndicator.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorTextIndicator == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorTextIndicator);
        }

        // POST: WorkplaceLanguageCapacitorTextIndicator/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Workplace_CapacitorTextIndicatorKey,CompetencyKey,Source,EnglishCompetencyName,EnglishIndicator,SpanishCompetencyName,SpanishIndicator,GermanCompetencyName,GermanIndicator,ChineseCompetencyName,ChineseIndicator,PortugueseCompetencyName,PortugueseIndicator")] tblWorkplace_LanguageCapacitorTextIndicator tblWorkplace_LanguageCapacitorTextIndicator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageCapacitorTextIndicator).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageCapacitorTextIndicator);
        }

        // GET: WorkplaceLanguageCapacitorTextIndicator/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorTextIndicator tblWorkplace_LanguageCapacitorTextIndicator = await db.tblWorkplace_LanguageCapacitorTextIndicator.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorTextIndicator == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorTextIndicator);
        }

        // POST: WorkplaceLanguageCapacitorTextIndicator/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageCapacitorTextIndicator tblWorkplace_LanguageCapacitorTextIndicator = await db.tblWorkplace_LanguageCapacitorTextIndicator.FindAsync(id);
            db.tblWorkplace_LanguageCapacitorTextIndicator.Remove(tblWorkplace_LanguageCapacitorTextIndicator);
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
