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
    public class ClienteExternoController : Controller
    {
        private dbContext db = new dbContext();

        // GET: ClienteExterno
        public ActionResult Index()
        {
            return View(db.ClienteExternoes.ToList());
        }

        // GET: ClienteExterno/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteExterno clienteExterno = db.ClienteExternoes.Find(id);
            if (clienteExterno == null)
            {
                return HttpNotFound();
            }
            return View(clienteExterno);
        }

        // GET: ClienteExterno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteExterno/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_ClienteExterno,CExt_Nombre,CExt_Direccion,CExt_Telefono,CExt_FechaCreacion,CExt_Estado")] ClienteExterno clienteExterno)
        {
            if (ModelState.IsValid)
            {
                db.ClienteExternoes.Add(clienteExterno);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(clienteExterno);
        }

        // GET: ClienteExterno/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteExterno clienteExterno = db.ClienteExternoes.Find(id);
            if (clienteExterno == null)
            {
                return HttpNotFound();
            }
            return View(clienteExterno);
        }

        // POST: ClienteExterno/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_ClienteExterno,CExt_Nombre,CExt_Direccion,CExt_Telefono,CExt_FechaCreacion,CExt_Estado")] ClienteExterno clienteExterno)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clienteExterno).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(clienteExterno);
        }

        // GET: ClienteExterno/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClienteExterno clienteExterno = db.ClienteExternoes.Find(id);
            if (clienteExterno == null)
            {
                return HttpNotFound();
            }
            return View(clienteExterno);
        }

        // POST: ClienteExterno/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClienteExterno clienteExterno = db.ClienteExternoes.Find(id);
            db.ClienteExternoes.Remove(clienteExterno);
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
