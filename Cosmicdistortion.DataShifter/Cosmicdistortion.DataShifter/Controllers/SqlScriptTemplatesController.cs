using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Cosmicdistortion.DataShifter;
using Cosmicdistortion.DataShifter.Models;

namespace Cosmicdistortion.DataShifter.Controllers
{
    public class SqlScriptTemplatesController : Controller
    {
        private ShifterContext db = new ShifterContext();

        // GET: SqlScriptTemplates
        public async Task<ActionResult> Index()
        {
            return View(await db.SqlScriptTemplates.ToListAsync());
        }

        // GET: SqlScriptTemplates/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SqlScriptTemplate sqlScriptTemplate = await db.SqlScriptTemplates.FindAsync(id);
            if (sqlScriptTemplate == null)
            {
                return HttpNotFound();
            }
            return View(sqlScriptTemplate);
        }

        // GET: SqlScriptTemplates/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SqlScriptTemplates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "SqlScriptTemplateId,Name,Template")] SqlScriptTemplate sqlScriptTemplate)
        {
            if (ModelState.IsValid)
            {
                db.SqlScriptTemplates.Add(sqlScriptTemplate);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(sqlScriptTemplate);
        }

        // GET: SqlScriptTemplates/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SqlScriptTemplate sqlScriptTemplate = await db.SqlScriptTemplates.FindAsync(id);
            if (sqlScriptTemplate == null)
            {
                return HttpNotFound();
            }
            return View(sqlScriptTemplate);
        }

        // POST: SqlScriptTemplates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "SqlScriptTemplateId,Name,Template")] SqlScriptTemplate sqlScriptTemplate)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sqlScriptTemplate).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(sqlScriptTemplate);
        }

        // GET: SqlScriptTemplates/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SqlScriptTemplate sqlScriptTemplate = await db.SqlScriptTemplates.FindAsync(id);
            if (sqlScriptTemplate == null)
            {
                return HttpNotFound();
            }
            return View(sqlScriptTemplate);
        }

        // POST: SqlScriptTemplates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            SqlScriptTemplate sqlScriptTemplate = await db.SqlScriptTemplates.FindAsync(id);
            db.SqlScriptTemplates.Remove(sqlScriptTemplate);
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
