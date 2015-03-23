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
    public class WorkplaceLanguageNarratorGroupController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageNarratorGroup
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageNarratorGroup.ToListAsync());
        }

        // GET: WorkplaceLanguageNarratorGroup/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageNarratorGroup tblWorkplace_LanguageNarratorGroup = await db.tblWorkplace_LanguageNarratorGroup.FindAsync(id);
            if (tblWorkplace_LanguageNarratorGroup == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageNarratorGroup);
        }

        // GET: WorkplaceLanguageNarratorGroup/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkplaceLanguageNarratorGroup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Workplace_LanguageNarratorGroupKey,LanguageKey,Group,Title")] tblWorkplace_LanguageNarratorGroup tblWorkplace_LanguageNarratorGroup)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageNarratorGroup.Add(tblWorkplace_LanguageNarratorGroup);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageNarratorGroup);
        }

        // GET: WorkplaceLanguageNarratorGroup/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageNarratorGroup tblWorkplace_LanguageNarratorGroup = await db.tblWorkplace_LanguageNarratorGroup.FindAsync(id);
            if (tblWorkplace_LanguageNarratorGroup == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageNarratorGroup);
        }

        // POST: WorkplaceLanguageNarratorGroup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Workplace_LanguageNarratorGroupKey,LanguageKey,Group,Title")] tblWorkplace_LanguageNarratorGroup tblWorkplace_LanguageNarratorGroup)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageNarratorGroup).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageNarratorGroup);
        }

        // GET: WorkplaceLanguageNarratorGroup/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageNarratorGroup tblWorkplace_LanguageNarratorGroup = await db.tblWorkplace_LanguageNarratorGroup.FindAsync(id);
            if (tblWorkplace_LanguageNarratorGroup == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageNarratorGroup);
        }

        // POST: WorkplaceLanguageNarratorGroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageNarratorGroup tblWorkplace_LanguageNarratorGroup = await db.tblWorkplace_LanguageNarratorGroup.FindAsync(id);
            db.tblWorkplace_LanguageNarratorGroup.Remove(tblWorkplace_LanguageNarratorGroup);
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
