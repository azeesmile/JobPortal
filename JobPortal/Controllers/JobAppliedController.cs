using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using JobPortal.Models;

namespace JobPortal.Controllers
{
    public class JobAppliedController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /JobApplied/
        public async Task<ActionResult> Index()
        {
            return View(await db.Applied_Job.ToListAsync());
        }

        // GET: /JobApplied/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applied_Job applied_job = await db.Applied_Job.FindAsync(id);
            if (applied_job == null)
            {
                return HttpNotFound();
            }
            return View(applied_job);
        }

        // GET: /JobApplied/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /JobApplied/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Applied_Job applied_job)
        {
            if (ModelState.IsValid)
            {
                db.Applied_Job.Add(applied_job);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(applied_job);
        }

        // GET: /JobApplied/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applied_Job applied_job = await db.Applied_Job.FindAsync(id);
            if (applied_job == null)
            {
                return HttpNotFound();
            }
            return View(applied_job);
        }

        // POST: /JobApplied/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Applied_Job applied_job)
        {
            if (ModelState.IsValid)
            {
                db.Entry(applied_job).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(applied_job);
        }

        // GET: /JobApplied/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Applied_Job applied_job = await db.Applied_Job.FindAsync(id);
            if (applied_job == null)
            {
                return HttpNotFound();
            }
            return View(applied_job);
        }

        // POST: /JobApplied/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Applied_Job applied_job = await db.Applied_Job.FindAsync(id);
            db.Applied_Job.Remove(applied_job);
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
