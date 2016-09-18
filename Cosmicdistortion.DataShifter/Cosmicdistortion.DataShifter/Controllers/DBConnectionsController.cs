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
    public class DBConnectionsController : Controller
    {
        private ShifterContext db = new ShifterContext();

        // GET: DBConnections
        public async Task<ActionResult> Index()
        {
            return View(await db.DBConnections.ToListAsync());
        }

        // GET: DBConnections/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBConnection dBConnection = await db.DBConnections.FindAsync(id);
            if (dBConnection == null)
            {
                return HttpNotFound();
            }
            return View(dBConnection);
        }

        // GET: DBConnections/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DBConnections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "DBConnectionId,Name,DataSource,IntegratedSecurity,InitialCatalog,Username,Password")] DBConnection dBConnection)
        {
            if (ModelState.IsValid)
            {
                db.DBConnections.Add(dBConnection);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(dBConnection);
        }

        // GET: DBConnections/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBConnection dBConnection = await db.DBConnections.FindAsync(id);
            if (dBConnection == null)
            {
                return HttpNotFound();
            }
            return View(dBConnection);
        }

        // POST: DBConnections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "DBConnectionId,Name,DataSource,IntegratedSecurity,InitialCatalog,Username,Password")] DBConnection dBConnection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dBConnection).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(dBConnection);
        }

        // GET: DBConnections/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DBConnection dBConnection = await db.DBConnections.FindAsync(id);
            if (dBConnection == null)
            {
                return HttpNotFound();
            }
            return View(dBConnection);
        }

        // POST: DBConnections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            DBConnection dBConnection = await db.DBConnections.FindAsync(id);
            db.DBConnections.Remove(dBConnection);
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
