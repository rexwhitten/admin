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
    public class WorkplaceLanguageCapacitorController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageCapacitor
        public async Task<ActionResult> Index()
        {
            return PartialView(await db.tblWorkplace_LanguageCapacitorHighPerformance.ToListAsync());
        }

        // GET: WorkplaceLanguageCapacitor/Details/5
        public async Task<ActionResult> Details(int? id)
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
            return PartialView(tblWorkplace_LanguageCapacitorHighPerformance);
        }

        // GET: WorkplaceLanguageCapacitor/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: WorkplaceLanguageCapacitor/Create
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

            return PartialView(tblWorkplace_LanguageCapacitorHighPerformance);
        }

        // GET: WorkplaceLanguageCapacitor/Edit/5
        public async Task<ActionResult> Edit(int? id)
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
            return PartialView(tblWorkplace_LanguageCapacitorHighPerformance);
        }

        // POST: WorkplaceLanguageCapacitor/Edit/5
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
            return PartialView(tblWorkplace_LanguageCapacitorHighPerformance);
        }

        // GET: WorkplaceLanguageCapacitor/Delete/5
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
            return PartialView(tblWorkplace_LanguageCapacitorHighPerformance);
        }

        // POST: WorkplaceLanguageCapacitor/Delete/5
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
