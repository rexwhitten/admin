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
    public class WorkplaceLanguageConsultantTOCController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageConsultantTOC
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageConsultantTOC.ToListAsync());
        }

        // GET: WorkplaceLanguageConsultantTOC/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultantTOC tblWorkplace_LanguageConsultantTOC = await db.tblWorkplace_LanguageConsultantTOC.FindAsync(id);
            if (tblWorkplace_LanguageConsultantTOC == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultantTOC);
        }

        // GET: WorkplaceLanguageConsultantTOC/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkplaceLanguageConsultantTOC/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ConsultantTOCKey,LanguageKey,ReportTitle,Introduction,IndivTraitScores,ResponseBias,ItemResponses,TraitBlends,TraitSummary,Page,Rights")] tblWorkplace_LanguageConsultantTOC tblWorkplace_LanguageConsultantTOC)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageConsultantTOC.Add(tblWorkplace_LanguageConsultantTOC);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageConsultantTOC);
        }

        // GET: WorkplaceLanguageConsultantTOC/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultantTOC tblWorkplace_LanguageConsultantTOC = await db.tblWorkplace_LanguageConsultantTOC.FindAsync(id);
            if (tblWorkplace_LanguageConsultantTOC == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultantTOC);
        }

        // POST: WorkplaceLanguageConsultantTOC/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ConsultantTOCKey,LanguageKey,ReportTitle,Introduction,IndivTraitScores,ResponseBias,ItemResponses,TraitBlends,TraitSummary,Page,Rights")] tblWorkplace_LanguageConsultantTOC tblWorkplace_LanguageConsultantTOC)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageConsultantTOC).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageConsultantTOC);
        }

        // GET: WorkplaceLanguageConsultantTOC/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultantTOC tblWorkplace_LanguageConsultantTOC = await db.tblWorkplace_LanguageConsultantTOC.FindAsync(id);
            if (tblWorkplace_LanguageConsultantTOC == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultantTOC);
        }

        // POST: WorkplaceLanguageConsultantTOC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageConsultantTOC tblWorkplace_LanguageConsultantTOC = await db.tblWorkplace_LanguageConsultantTOC.FindAsync(id);
            db.tblWorkplace_LanguageConsultantTOC.Remove(tblWorkplace_LanguageConsultantTOC);
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
