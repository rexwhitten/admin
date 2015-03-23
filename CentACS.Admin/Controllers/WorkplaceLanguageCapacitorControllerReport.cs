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
    public class WorkplaceLanguageCapacitorControllerReport : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageCapacitorControllerReport
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageCapacitorReport.ToListAsync());
        }

        // GET: WorkplaceLanguageCapacitorControllerReport/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorReport tblWorkplace_LanguageCapacitorReport = await db.tblWorkplace_LanguageCapacitorReport.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorReport == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorReport);
        }

        // GET: WorkplaceLanguageCapacitorControllerReport/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkplaceLanguageCapacitorControllerReport/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LanguageCapacitorCompReportKey,LanguageKey,ReportHeader,EstimatedFit,InterpretationOfFit,FitLegend,OptimumHeader,ActualHeader,AvailableHeader,DescriptionHeader,IndicatorPrefix,SourceText")] tblWorkplace_LanguageCapacitorReport tblWorkplace_LanguageCapacitorReport)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageCapacitorReport.Add(tblWorkplace_LanguageCapacitorReport);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageCapacitorReport);
        }

        // GET: WorkplaceLanguageCapacitorControllerReport/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorReport tblWorkplace_LanguageCapacitorReport = await db.tblWorkplace_LanguageCapacitorReport.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorReport == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorReport);
        }

        // POST: WorkplaceLanguageCapacitorControllerReport/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LanguageCapacitorCompReportKey,LanguageKey,ReportHeader,EstimatedFit,InterpretationOfFit,FitLegend,OptimumHeader,ActualHeader,AvailableHeader,DescriptionHeader,IndicatorPrefix,SourceText")] tblWorkplace_LanguageCapacitorReport tblWorkplace_LanguageCapacitorReport)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageCapacitorReport).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageCapacitorReport);
        }

        // GET: WorkplaceLanguageCapacitorControllerReport/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCapacitorReport tblWorkplace_LanguageCapacitorReport = await db.tblWorkplace_LanguageCapacitorReport.FindAsync(id);
            if (tblWorkplace_LanguageCapacitorReport == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCapacitorReport);
        }

        // POST: WorkplaceLanguageCapacitorControllerReport/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageCapacitorReport tblWorkplace_LanguageCapacitorReport = await db.tblWorkplace_LanguageCapacitorReport.FindAsync(id);
            db.tblWorkplace_LanguageCapacitorReport.Remove(tblWorkplace_LanguageCapacitorReport);
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
