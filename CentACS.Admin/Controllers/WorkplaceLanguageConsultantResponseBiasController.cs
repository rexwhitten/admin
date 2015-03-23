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
    public class WorkplaceLanguageConsultantResponseBiasController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageConsultantResponseBias
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageConsultantResponseBias.ToListAsync());
        }

        // GET: WorkplaceLanguageConsultantResponseBias/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultantResponseBias tblWorkplace_LanguageConsultantResponseBias = await db.tblWorkplace_LanguageConsultantResponseBias.FindAsync(id);
            if (tblWorkplace_LanguageConsultantResponseBias == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultantResponseBias);
        }

        // GET: WorkplaceLanguageConsultantResponseBias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkplaceLanguageConsultantResponseBias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LangaugeResponseBiasKey,LanguageKey,ResponseBias,ResponseBiasText")] tblWorkplace_LanguageConsultantResponseBias tblWorkplace_LanguageConsultantResponseBias)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageConsultantResponseBias.Add(tblWorkplace_LanguageConsultantResponseBias);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageConsultantResponseBias);
        }

        // GET: WorkplaceLanguageConsultantResponseBias/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultantResponseBias tblWorkplace_LanguageConsultantResponseBias = await db.tblWorkplace_LanguageConsultantResponseBias.FindAsync(id);
            if (tblWorkplace_LanguageConsultantResponseBias == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultantResponseBias);
        }

        // POST: WorkplaceLanguageConsultantResponseBias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LangaugeResponseBiasKey,LanguageKey,ResponseBias,ResponseBiasText")] tblWorkplace_LanguageConsultantResponseBias tblWorkplace_LanguageConsultantResponseBias)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageConsultantResponseBias).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageConsultantResponseBias);
        }

        // GET: WorkplaceLanguageConsultantResponseBias/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultantResponseBias tblWorkplace_LanguageConsultantResponseBias = await db.tblWorkplace_LanguageConsultantResponseBias.FindAsync(id);
            if (tblWorkplace_LanguageConsultantResponseBias == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultantResponseBias);
        }

        // POST: WorkplaceLanguageConsultantResponseBias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageConsultantResponseBias tblWorkplace_LanguageConsultantResponseBias = await db.tblWorkplace_LanguageConsultantResponseBias.FindAsync(id);
            db.tblWorkplace_LanguageConsultantResponseBias.Remove(tblWorkplace_LanguageConsultantResponseBias);
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
