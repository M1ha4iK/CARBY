using CARBY_KURSACH_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CARBY_KURSACH_.Controllers
{
    public class HomeController : Controller
    {
        CarContext db = new CarContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Catalog()
        {
            return View();
        }
        public ActionResult Reviews()
        {
            return View();
        }
        public ActionResult Promotions()
        {
            return View();
        }
        public ActionResult AboutCompany()
        {
            return View();
        }
        public ActionResult Audi()
        {
            return View(db.AudiS);
        }

        public ActionResult BMW()
        {
            return View(db.BMWS);
        }

        public ActionResult Chevrolet()
        {
            return View(db.ChevroletS);
        }

        public ActionResult Dacia()
        {
            return View(db.DaciaS);
        }

        public ActionResult Ford()
        {
            return View(db.FordS);
        }


        public ActionResult Honda()
        {
            return View(db.HondaS);
        }

        public ActionResult Infiniti()
        {
            return View(db.InfinitiS);
        }

        public ActionResult Jaguar()
        {
            return View(db.JaguarS);
        }

        public ActionResult Kia()
        {
            return View(db.KiaS);
        }

        public ActionResult Lada()
        {
            return View(db.LadaS);
        }

        public ActionResult Mazda()
        {
            return View(db.MazdaS);
        }

        public ActionResult Nissan()
        {
            return View(db.NissanS);
        }

        public ActionResult Porsche()
        {
            return View(db.PorscheS);
        }

        public ActionResult Tesla()
        {
            return View(db.TeslaS);
        }


        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Id = id;
            return View();
        }


        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;

            db.Purchases.Add(purchase);

            db.SaveChanges();

            return $"Уважаемый, {purchase.Person}, автомобиль забронирован на 5 дней!";
        }

      
    }
}