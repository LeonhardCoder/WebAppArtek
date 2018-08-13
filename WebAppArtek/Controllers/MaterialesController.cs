using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebAppArtek.Models;

namespace WebAppArtek.Controllers
{
    public class MaterialesController : Controller
    {
        private dbContext db = new dbContext();

        // GET: Materiales
        public ActionResult Index()
        {
            return View(db.MaterialesModels.ToList());
        }

        // GET: Materiales/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materiales materiales = db.MaterialesModels.Find(id);
            if (materiales == null)
            {
                return HttpNotFound();
            }
            return View(materiales);
        }

        // GET: Materiales/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Materiales/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_Materiales,Mat_Nombre,Mat_Descripcion,Mat_Estado")] Materiales materiales)
        {
            if (ModelState.IsValid)
            {
                db.MaterialesModels.Add(materiales);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(materiales);
        }

        // GET: Materiales/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materiales materiales = db.MaterialesModels.Find(id);
            if (materiales == null)
            {
                return HttpNotFound();
            }
            return View(materiales);
        }

        // POST: Materiales/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_Materiales,Mat_Nombre,Mat_Descripcion,Mat_Estado")] Materiales materiales)
        {
            if (ModelState.IsValid)
            {
                db.Entry(materiales).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(materiales);
        }

        // GET: Materiales/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Materiales materiales = db.MaterialesModels.Find(id);
            if (materiales == null)
            {
                return HttpNotFound();
            }
            return View(materiales);
        }

        // POST: Materiales/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Materiales materiales = db.MaterialesModels.Find(id);
            db.MaterialesModels.Remove(materiales);
            db.SaveChanges();
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
