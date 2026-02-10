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
    public class NhanViensController : Controller
    {
        private Model1 db = new Model1();

        // GET: NhanViens
        public async Task<ActionResult> Index()
        {

            return View(await db.NhanViens.ToListAsync());
        }

        // GET: NhanViens/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = await db.NhanViens.FindAsync(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // GET: NhanViens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NhanViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "MaNV,HoDem,Ten,GioiTinh,TenPhong,Email,LuongNgay")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                db.NhanViens.Add(nhanVien);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(nhanVien);
        }

        // GET: NhanViens/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = await db.NhanViens.FindAsync(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "MaNV,HoDem,Ten,GioiTinh,TenPhong,Email,LuongNgay")] NhanVien nhanVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhanVien).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nhanVien);
        }

        // GET: NhanViens/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NhanVien nhanVien = await db.NhanViens.FindAsync(id);
            if (nhanVien == null)
            {
                return HttpNotFound();
            }
            return View(nhanVien);
        }

        // POST: NhanViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            NhanVien nhanVien = await db.NhanViens.FindAsync(id);
            db.NhanViens.Remove(nhanVien);
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
