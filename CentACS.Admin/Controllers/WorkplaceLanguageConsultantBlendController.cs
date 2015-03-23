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
    public class WorkplaceLanguageConsultantBlendController : Controller
    {
        private CentACSAssessmentsEntities db = new CentACSAssessmentsEntities();

        // GET: WorkplaceLanguageConsultantBlend
        public async Task<ActionResult> Index()
        {
            return View(await db.tblWorkplace_LanguageConsultantBlend.ToListAsync());
        }

        // GET: WorkplaceLanguageConsultantBlend/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultantBlend tblWorkplace_LanguageConsultantBlend = await db.tblWorkplace_LanguageConsultantBlend.FindAsync(id);
            if (tblWorkplace_LanguageConsultantBlend == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultantBlend);
        }

        // GET: WorkplaceLanguageConsultantBlend/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: WorkplaceLanguageConsultantBlend/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ConsultantBlendKey,LanguageKey,BlendEnum,Blend,EnglishName,EnglishDefinition,SpanishName,SpanishDefinition,GermanName,GermanDefinition,ChineseName,ChineseDefinition,PortugueseName,PortugueseDefinition")] tblWorkplace_LanguageConsultantBlend tblWorkplace_LanguageConsultantBlend)
        {
            if (ModelState.IsValid)
            {
                db.tblWorkplace_LanguageConsultantBlend.Add(tblWorkplace_LanguageConsultantBlend);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(tblWorkplace_LanguageConsultantBlend);
        }

        // GET: WorkplaceLanguageConsultantBlend/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultantBlend tblWorkplace_LanguageConsultantBlend = await db.tblWorkplace_LanguageConsultantBlend.FindAsync(id);
            if (tblWorkplace_LanguageConsultantBlend == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultantBlend);
        }

        // POST: WorkplaceLanguageConsultantBlend/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ConsultantBlendKey,LanguageKey,BlendEnum,Blend,EnglishName,EnglishDefinition,SpanishName,SpanishDefinition,GermanName,GermanDefinition,ChineseName,ChineseDefinition,PortugueseName,PortugueseDefinition")] tblWorkplace_LanguageConsultantBlend tblWorkplace_LanguageConsultantBlend)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tblWorkplace_LanguageConsultantBlend).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(tblWorkplace_LanguageConsultantBlend);
        }

        // GET: WorkplaceLanguageConsultantBlend/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblWorkplace_LanguageConsultantBlend tblWorkplace_LanguageConsultantBlend = await db.tblWorkplace_LanguageConsultantBlend.FindAsync(id);
            if (tblWorkplace_LanguageConsultantBlend == null)
            {
                return HttpNotFound();
            }
            return View(tblWorkplace_LanguageConsultantBlend);
        }

        // POST: WorkplaceLanguageConsultantBlend/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblWorkplace_LanguageConsultantBlend tblWorkplace_LanguageConsultantBlend = await db.tblWorkplace_LanguageConsultantBlend.FindAsync(id);
            db.tblWorkplace_LanguageConsultantBlend.Remove(tblWorkplace_LanguageConsultantBlend);
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
