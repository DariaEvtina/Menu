using Menu.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;


namespace Menu.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Menu1 menu;
            return View();
        }
        Menu1Context db = new Menu1Context();
        public ActionResult Menus1()
        {
            IEnumerable<Menu1> menus1 = db.Menus1;
            return View(menus1);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [Authorize]
        [HttpGet]

        public ActionResult CreateMenu1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMenu1(Menu1 menu1)
        {
            db.Menus1.Add(menu1);
            db.SaveChanges();
            return RedirectToAction("Menus1");
        }
        [Authorize]
        [HttpGet]

        public ActionResult DeleteMenu1(int id)
        {
            Menu1 g = db.Menus1.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            return View(g);
        }
        [HttpPost, ActionName("DeleteMenu1")]
        public ActionResult DeleteConfirmedMenu1(int id)
        {
            Menu1 g = db.Menus1.Find(id);
            if (g == null)
            {
                return HttpNotFound();
            }
            db.Menus1.Remove(g);
            db.SaveChanges();
            return RedirectToAction("Menus1");
        }
        [Authorize]
        [HttpGet]
        public ActionResult EditMenu1(int? id)
        {
            Menu1 gp = db.Menus1.Find(id);
            if (gp == null)
            {
                return HttpNotFound();
            }
            return View(gp);
        }
        [HttpPost, ActionName("EditMenu1")]
        public ActionResult EditConfirmedPidu(Menu1 menu1)
        {
            db.Entry(menu1).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Menus1");
        }
    }
}