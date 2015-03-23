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
    public class WorkplaceLanguageConsultantController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageConsultant
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageConsultant.ToListAsync());
        }

        // GET: WorkplaceLanguageConsultant/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultant tblWorkplace_LanguageConsultant = await db.tblWorkplace_LanguageConsultant.FindAsync(id);
            if (tblWorkplace_LanguageConsultant == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultant);
        }

        // GET: WorkplaceLanguageConsultant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkplaceLanguageConsultant/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LanguageConsultantKey,LanguageKey,DevelopedBy,Introduction,Note,NoteText,Pure,Situational,Polarized,EvidenceBias,EvidenceBiasLegend,ItemResponses")] tblWorkplace_LanguageConsultant tblWorkplace_LanguageConsultant)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageConsultant.Add(tblWorkplace_LanguageConsultant);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageConsultant);
        }

        // GET: WorkplaceLanguageConsultant/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultant tblWorkplace_LanguageConsultant = await db.tblWorkplace_LanguageConsultant.FindAsync(id);
            if (tblWorkplace_LanguageConsultant == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultant);
        }

        // POST: WorkplaceLanguageConsultant/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LanguageConsultantKey,LanguageKey,DevelopedBy,Introduction,Note,NoteText,Pure,Situational,Polarized,EvidenceBias,EvidenceBiasLegend,ItemResponses")] tblWorkplace_LanguageConsultant tblWorkplace_LanguageConsultant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageConsultant).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageConsultant);
        }

        // GET: WorkplaceLanguageConsultant/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultant tblWorkplace_LanguageConsultant = await db.tblWorkplace_LanguageConsultant.FindAsync(id);
            if (tblWorkplace_LanguageConsultant == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultant);
        }

        // POST: WorkplaceLanguageConsultant/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageConsultant tblWorkplace_LanguageConsultant = await db.tblWorkplace_LanguageConsultant.FindAsync(id);
            db.tblWorkplace_LanguageConsultant.Remove(tblWorkplace_LanguageConsultant);
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
