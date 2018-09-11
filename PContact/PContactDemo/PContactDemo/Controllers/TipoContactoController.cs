using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PContactDemo.Models;

namespace PContactDemo.Controllers
{
    public class TipoContactoController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TipoContacto
        public ActionResult Index()
        {
            return View(db.TipoContacto.ToList());
        }

        // GET: TipoContacto/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoContacto tipoContacto = db.TipoContacto.Find(id);
            if (tipoContacto == null)
            {
                return HttpNotFound();
            }
            return View(tipoContacto);
        }

        // GET: TipoContacto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoContacto/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TipoContacto tipoContacto)
        {
            if (ModelState.IsValid)
            {
                tipoContacto.Activo = true;
                tipoContacto.UsuarioCreacion = "admin";
                tipoContacto.UsuarioModificacion = "admin";
                tipoContacto.FechaCreacion = DateTime.Now;
                tipoContacto.FechaModificacion = DateTime.Now;
                
                db.TipoContacto.Add(tipoContacto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoContacto);
        }

        // GET: TipoContacto/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoContacto tipoContacto = db.TipoContacto.Find(id);
            if (tipoContacto == null)
            {
                return HttpNotFound();
            }
            return View(tipoContacto);
        }

        // POST: TipoContacto/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( TipoContacto tipoContacto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoContacto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoContacto);
        }

        // GET: TipoContacto/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    TipoContacto tipoContacto = db.TipoContacto.Find(id);
        //    if (tipoContacto == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(tipoContacto);
        //}

        //// POST: TipoContacto/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    TipoContacto tipoContacto = db.TipoContacto.Find(id);
        //    db.TipoContacto.Remove(tipoContacto);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
