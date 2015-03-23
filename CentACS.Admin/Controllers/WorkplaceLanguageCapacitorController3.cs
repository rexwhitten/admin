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
    public class WorkplaceLanguageCapacitorController3 : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageCapacitorController3
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageCapacitorIntro.ToListAsync());
        }

        // GET: WorkplaceLanguageCapacitorController3/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorIntro tblWorkplace_LanguageCapacitorIntro = await db.tblWorkplace_LanguageCapacitorIntro.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorIntro == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorIntro);
        }

        // GET: WorkplaceLanguageCapacitorController3/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkplaceLanguageCapacitorController3/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LanguageCapacitorKey,LanguageKey,DevelopedBy,SummaryHeader,SummaryText,ReportDescHeader,ReportDescText,CompetencySubHeader,CompetencyHeader,ImportantNote,ImportantNoteText")] tblWorkplace_LanguageCapacitorIntro tblWorkplace_LanguageCapacitorIntro)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageCapacitorIntro.Add(tblWorkplace_LanguageCapacitorIntro);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageCapacitorIntro);
        }

        // GET: WorkplaceLanguageCapacitorController3/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorIntro tblWorkplace_LanguageCapacitorIntro = await db.tblWorkplace_LanguageCapacitorIntro.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorIntro == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorIntro);
        }

        // POST: WorkplaceLanguageCapacitorController3/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LanguageCapacitorKey,LanguageKey,DevelopedBy,SummaryHeader,SummaryText,ReportDescHeader,ReportDescText,CompetencySubHeader,CompetencyHeader,ImportantNote,ImportantNoteText")] tblWorkplace_LanguageCapacitorIntro tblWorkplace_LanguageCapacitorIntro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageCapacitorIntro).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageCapacitorIntro);
        }

        // GET: WorkplaceLanguageCapacitorController3/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorIntro tblWorkplace_LanguageCapacitorIntro = await db.tblWorkplace_LanguageCapacitorIntro.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorIntro == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorIntro);
        }

        // POST: WorkplaceLanguageCapacitorController3/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageCapacitorIntro tblWorkplace_LanguageCapacitorIntro = await db.tblWorkplace_LanguageCapacitorIntro.FindAsync(id);
            db.tblWorkplace_LanguageCapacitorIntro.Remove(tblWorkplace_LanguageCapacitorIntro);
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
