using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using PrimerASPProject.Context;
using PrimerASPProject.Models;

namespace PrimerASPProject.Controllers
{
    public class ProductoController : Controller {
        private DataStore db = new DataStore();
        // GET: Producto
        public ActionResult Index() { return View(db.Productos.ToList()); }
        // GET: Producto/Details/5
        public ActionResult Details(int id) { return View("~/Views/Producto/Details.cshtml",db.Productos.Find(id));  }
        // GET: Producto/Create
        public ActionResult Create()  { return View("~/Views/Producto/Create.cshtml");  }
        // POST: Producto/Create
        [HttpPost]
        public ActionResult Create(Producto p)  {
            try {if (ModelState.IsValid) { db.Productos.Add(p); db.SaveChanges(); return RedirectToAction("Index"); }
                 return View(p);     } catch { return View();  }
        }
        // GET: Producto/Edit/5
        public ActionResult Edit(int id) { return View("~/Views/Producto/Edit.cshtml",db.Productos.Find(id));   }
        // POST: Producto/Edit/5
        [HttpPost]
        public ActionResult Edit(Producto p, FormCollection collection)  {
            try {db.Entry(p).State = EntityState.Modified;db.SaveChanges();
                 return RedirectToAction("Index");  } catch { return View(); }
        }
        // GET: Producto/Delete/5
        public ActionResult Delete(int id)  {return View("~/Views/Producto/Delete.cshtml", db.Productos.Find(id));  }
        // POST: Producto/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection) {
            try {Producto p = db.Productos.Find(id); if (p!=null) { db.Productos.Remove(p); db.SaveChanges(); }
                 return RedirectToAction("Index");} catch { return View(); }
        }
    }
}