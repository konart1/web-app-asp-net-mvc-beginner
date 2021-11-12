using System.Web.Mvc;
using System.Data.Entity;
using Shop.Models;
using System.Collections.Generic;
using Shopogolick.Models;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        ThingContext db = new ThingContext();
        public ActionResult Index()
        {
            // Получаем из бд все объекты
            IEnumerable<Thing> things = db.Things;

            // Передаем все объекты в динамическое свойство
            ViewBag.Things = things;

            return View ();
        }

        [HttpPost]
        public ActionResult Create(Thing thing)
        {
            db.Things.Add(thing);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        
        public ActionResult Delete( int id)
        {
            Thing i = db.Things.Find(id);

            if (i != null)
            {
                db.Things.Remove(i);
                db.SaveChanges();
            }

            return RedirectToAction("Index");

        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Thing thing = db.Things.Find(id);

            if (thing != null)
            {
                return View(thing);
            }

            return HttpNotFound();
            
        }

        [HttpPost]
        public ActionResult Edit (Thing thing)
        {
            db.Entry(thing).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}