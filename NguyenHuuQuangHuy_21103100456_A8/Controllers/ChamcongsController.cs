using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NguyenHuuQuangHuy_21103100456_A8.Models;

namespace NguyenHuuQuangHuy_21103100456_A8.Controllers
{
    public class ChamcongsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Chamcongs
        public async Task<ActionResult> Index()
        {
            var chamCongs = db.ChamCongs.Include(c => c.NhanViens);
            return View(await chamCongs.ToListAsync());
        }

        // GET: Chamcongs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamcong chamcong = await db.ChamCongs.FindAsync(id);
            if (chamcong == null)
            {
                return HttpNotFound();
            }
            return View(chamcong);
        }

        // GET: Chamcongs/Create
        public ActionResult Create()
        {
            ViewBag.MaNV = new SelectList(db.NhanViens, "MaNV", "HoDem");
            return View();
        }

        // POST: Chamcongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MaNV,Thang,SoNgayCong")] Chamcong chamcong)
        {
            if (ModelState.IsValid)
            {
                db.ChamCongs.Add(chamcong);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.MaNV = new SelectList(db.NhanViens, "MaNV", "HoDem", chamcong.MaNV);
            return View(chamcong);
        }

        // GET: Chamcongs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamcong chamcong = await db.ChamCongs.FindAsync(id);
            if (chamcong == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaNV = new SelectList(db.NhanViens, "MaNV", "HoDem", chamcong.MaNV);
            return View(chamcong);
        }

        // POST: Chamcongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MaNV,Thang,SoNgayCong")] Chamcong chamcong)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chamcong).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.MaNV = new SelectList(db.NhanViens, "MaNV", "HoDem", chamcong.MaNV);
            return View(chamcong);
        }

        // GET: Chamcongs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Chamcong chamcong = await db.ChamCongs.FindAsync(id);
            if (chamcong == null)
            {
                return HttpNotFound();
            }
            return View(chamcong);
        }

        // POST: Chamcongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Chamcong chamcong = await db.ChamCongs.FindAsync(id);
            db.ChamCongs.Remove(chamcong);
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
