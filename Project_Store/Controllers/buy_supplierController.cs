using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Project_Store.Models;

namespace Project_Store.Controllers
{
    public class buy_supplierController : Controller
    {
        private storeEntities db = new storeEntities();

        // GET: buy_supplier
        public ActionResult Index()
        {
            return View(db.buy_supplier.ToList());
        }

        // GET: buy_supplier/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            buy_supplier buy_supplier = db.buy_supplier.Find(id);
            if (buy_supplier == null)
            {
                return HttpNotFound();
            }
            return View(buy_supplier);
        }

        // GET: buy_supplier/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: buy_supplier/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,date,quantity,unit_value,total")] buy_supplier buy_supplier)
        {
            if (ModelState.IsValid)
            {
                db.buy_supplier.Add(buy_supplier);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(buy_supplier);
        }

        // GET: buy_supplier/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            buy_supplier buy_supplier = db.buy_supplier.Find(id);
            if (buy_supplier == null)
            {
                return HttpNotFound();
            }
            return View(buy_supplier);
        }

        // POST: buy_supplier/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,date,quantity,unit_value,total")] buy_supplier buy_supplier)
        {
            if (ModelState.IsValid)
            {
                db.Entry(buy_supplier).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(buy_supplier);
        }

        // GET: buy_supplier/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            buy_supplier buy_supplier = db.buy_supplier.Find(id);
            if (buy_supplier == null)
            {
                return HttpNotFound();
            }
            return View(buy_supplier);
        }

        // POST: buy_supplier/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            buy_supplier buy_supplier = db.buy_supplier.Find(id);
            db.buy_supplier.Remove(buy_supplier);
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
