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
    public class SalaryRangeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /SalaryRange/
        public async Task<ActionResult> Index()
        {
            return View(await db.Salaries_Range.ToListAsync());
        }

        // GET: /SalaryRange/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salaries_Range salaries_range = await db.Salaries_Range.FindAsync(id);
            if (salaries_range == null)
            {
                return HttpNotFound();
            }
            return View(salaries_range);
        }

        // GET: /SalaryRange/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /SalaryRange/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(Salaries_Range salaries_range)
        {
            if (ModelState.IsValid)
            {
                db.Salaries_Range.Add(salaries_range);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(salaries_range);
        }

        // GET: /SalaryRange/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salaries_Range salaries_range = await db.Salaries_Range.FindAsync(id);
            if (salaries_range == null)
            {
                return HttpNotFound();
            }
            return View(salaries_range);
        }

        // POST: /SalaryRange/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(Salaries_Range salaries_range)
        {
            if (ModelState.IsValid)
            {
                db.Entry(salaries_range).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(salaries_range);
        }

        // GET: /SalaryRange/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Salaries_Range salaries_range = await db.Salaries_Range.FindAsync(id);
            if (salaries_range == null)
            {
                return HttpNotFound();
            }
            return View(salaries_range);
        }

        // POST: /SalaryRange/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Salaries_Range salaries_range = await db.Salaries_Range.FindAsync(id);
            db.Salaries_Range.Remove(salaries_range);
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
