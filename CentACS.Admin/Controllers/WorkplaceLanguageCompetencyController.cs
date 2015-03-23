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
    public class WorkplaceLanguageCompetencyController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageCompetency
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageCompetencyName.ToListAsync());
        }

        // GET: WorkplaceLanguageCompetency/Details/5
        public async Task<ActionResult> Details(int? languageKey)
        {
            if (languageKey == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCompetencyName tblWorkplace_LanguageCompetencyName = await db.tblWorkplace_LanguageCompetencyName
                                                                                                    .Where(l => l.LanguageKey == languageKey)
                                                                                                    .FirstAsync();
            if (tblWorkplace_LanguageCompetencyName == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCompetencyName);
        }

        // GET: WorkplaceLanguageCompetency/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkplaceLanguageCompetency/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LanguageCompetencyNameKey,LanguageKey,CompetencyKey,Name")] tblWorkplace_LanguageCompetencyName tblWorkplace_LanguageCompetencyName)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageCompetencyName.Add(tblWorkplace_LanguageCompetencyName);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageCompetencyName);
        }

        // GET: WorkplaceLanguageCompetency/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCompetencyName tblWorkplace_LanguageCompetencyName = await db.tblWorkplace_LanguageCompetencyName.FindAsync(id);
            if (tblWorkplace_LanguageCompetencyName == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCompetencyName);
        }

        // POST: WorkplaceLanguageCompetency/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LanguageCompetencyNameKey,LanguageKey,CompetencyKey,Name")] tblWorkplace_LanguageCompetencyName tblWorkplace_LanguageCompetencyName)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageCompetencyName).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageCompetencyName);
        }

        // GET: WorkplaceLanguageCompetency/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageCompetencyName tblWorkplace_LanguageCompetencyName = await db.tblWorkplace_LanguageCompetencyName.FindAsync(id);
            if (tblWorkplace_LanguageCompetencyName == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageCompetencyName);
        }

        // POST: WorkplaceLanguageCompetency/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageCompetencyName tblWorkplace_LanguageCompetencyName = await db.tblWorkplace_LanguageCompetencyName.FindAsync(id);
            db.tblWorkplace_LanguageCompetencyName.Remove(tblWorkplace_LanguageCompetencyName);
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
