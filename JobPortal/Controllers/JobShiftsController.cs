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
    public class JobShiftsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /JobShifts/
        public async Task<ActionResult> Index()
        {
            return View(await db.Job_Shifts.ToListAsync());
        }

        // GET: /JobShifts/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_Shifts job_shifts = await db.Job_Shifts.FindAsync(id);
            if (job_shifts == null)
            {
                return HttpNotFound();
            }
            return View(job_shifts);
        }

        // GET: /JobShifts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /JobShifts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Job_Shifts job_shifts)
        {
            if (ModelState.IsValid)
            {
                db.Job_Shifts.Add(job_shifts);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(job_shifts);
        }

        // GET: /JobShifts/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_Shifts job_shifts = await db.Job_Shifts.FindAsync(id);
            if (job_shifts == null)
            {
                return HttpNotFound();
            }
            return View(job_shifts);
        }

        // POST: /JobShifts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Job_Shifts job_shifts)
        {
            if (ModelState.IsValid)
            {
                db.Entry(job_shifts).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(job_shifts);
        }

        // GET: /JobShifts/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Job_Shifts job_shifts = await db.Job_Shifts.FindAsync(id);
            if (job_shifts == null)
            {
                return HttpNotFound();
            }
            return View(job_shifts);
        }

        // POST: /JobShifts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Job_Shifts job_shifts = await db.Job_Shifts.FindAsync(id);
            db.Job_Shifts.Remove(job_shifts);
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
