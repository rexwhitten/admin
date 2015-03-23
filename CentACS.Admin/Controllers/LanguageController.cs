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
    public class LanguageController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: Language
        public async Task<ActionResult> Index()
        {
            return View(await db.tblMaster_Language.ToListAsync());
        }

        // GET: Language/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMaster_Language tblMaster_Language = await db.tblMaster_Language.FindAsync(id);
            if (tblMaster_Language == null)
            {
                return HttpNotFound();
            }
            return View(tblMaster_Language);
        }

        // GET: Language/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Language/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "LanguageKey,Language,Code,Rank,Active,DateCreated")] tblMaster_Language tblMaster_Language)
        {
            if (ModelState.IsValid)
            {
                db.tblMaster_Language.Add(tblMaster_Language);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblMaster_Language);
        }

        // GET: Language/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMaster_Language tblMaster_Language = await db.tblMaster_Language.FindAsync(id);
            if (tblMaster_Language == null)
            {
                return HttpNotFound();
            }
            return View(tblMaster_Language);
        }

        // POST: Language/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "LanguageKey,Language,Code,Rank,Active,DateCreated")] tblMaster_Language tblMaster_Language)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblMaster_Language).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblMaster_Language);
        }

        // GET: Language/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblMaster_Language tblMaster_Language = await db.tblMaster_Language.FindAsync(id);
            if (tblMaster_Language == null)
            {
                return HttpNotFound();
            }
            return View(tblMaster_Language);
        }

        // POST: Language/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblMaster_Language tblMaster_Language = await db.tblMaster_Language.FindAsync(id);
            db.tblMaster_Language.Remove(tblMaster_Language);
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
