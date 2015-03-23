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
    public class WorkplaceLanguageCapacitorInterpretationController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageCapacitorInterpretation
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageCapacitorInterpretation.ToListAsync());
        }

        // GET: WorkplaceLanguageCapacitorInterpretation/Details/5
        public async Task<ActionResult> Details(int? languageKey)
        {
            if (languageKey == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorInterpretation tblWorkplace_LanguageCapacitorInterpretation = await db.tblWorkplace_LanguageCapacitorInterpretation
                                                                                                                      .Where(l => l.LanguageKey == languageKey)
                                                                                                                      .FirstAsync();
            if (tblWorkplace_LanguageCapacitorInterpretation == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorInterpretation);
        }

        // GET: WorkplaceLanguageCapacitorInterpretation/Create
        public ActionResult Create(Int32 languageKey = 1)
        {
            var model = new tblWorkplace_LanguageCapacitorInterpretation()
            {
                LanguageKey = languageKey
            };

            return View(model);
        }

        // POST: WorkplaceLanguageCapacitorInterpretation/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CapacitorInterpretationKey,LanguageKey,FitInterpretation,Text")] tblWorkplace_LanguageCapacitorInterpretation tblWorkplace_LanguageCapacitorInterpretation)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageCapacitorInterpretation.Add(tblWorkplace_LanguageCapacitorInterpretation);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageCapacitorInterpretation);
        }

        // GET: WorkplaceLanguageCapacitorInterpretation/Edit/5
        public async Task<ActionResult> Edit(int? languageKey)
        {
            if (languageKey == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            // analyze results
            var results = await db.tblWorkplace_LanguageCapacitorInterpretation.Where(L => L.LanguageKey == languageKey).ToListAsync();

            if(results.Any()) {
                return View(results.First());
            }

            return RedirectToAction("Create", new { languageKey = languageKey });
        }

        // POST: WorkplaceLanguageCapacitorInterpretation/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CapacitorInterpretationKey,LanguageKey,FitInterpretation,Text")] tblWorkplace_LanguageCapacitorInterpretation tblWorkplace_LanguageCapacitorInterpretation)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageCapacitorInterpretation).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageCapacitorInterpretation);
        }

        // GET: WorkplaceLanguageCapacitorInterpretation/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorInterpretation tblWorkplace_LanguageCapacitorInterpretation = await db.tblWorkplace_LanguageCapacitorInterpretation.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorInterpretation == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorInterpretation);
        }

        // POST: WorkplaceLanguageCapacitorInterpretation/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageCapacitorInterpretation tblWorkplace_LanguageCapacitorInterpretation = await db.tblWorkplace_LanguageCapacitorInterpretation.FindAsync(id);
            db.tblWorkplace_LanguageCapacitorInterpretation.Remove(tblWorkplace_LanguageCapacitorInterpretation);
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
