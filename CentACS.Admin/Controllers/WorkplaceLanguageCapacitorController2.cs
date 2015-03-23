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
    public class WorkplaceLanguageCapacitorController2 : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageCapacitorController2
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageCapacitorInterpretation.ToListAsync());
        }

        // GET: WorkplaceLanguageCapacitorController2/Details/5
        public async Task<ActionResult> Details(int? id)
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

        // GET: WorkplaceLanguageCapacitorController2/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkplaceLanguageCapacitorController2/Create
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

        // GET: WorkplaceLanguageCapacitorController2/Edit/5
        public async Task<ActionResult> Edit(int? id)
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

        // POST: WorkplaceLanguageCapacitorController2/Edit/5
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

        // GET: WorkplaceLanguageCapacitorController2/Delete/5
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

        // POST: WorkplaceLanguageCapacitorController2/Delete/5
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
