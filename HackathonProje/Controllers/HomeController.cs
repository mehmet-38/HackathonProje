using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackathonProje.Models.Entity;


namespace HackathonProje.Controllers
{
    public class HomeController : Controller
    {
        hackhathonP01Entities3 db = new hackhathonP01Entities3();
        public ActionResult Index()
        {
            var isletmeler = db.tblIsletme.ToList();
            return View(isletmeler);
        }

        public ActionResult Cikis()
        {
            Session.Clear();
            return Redirect("~/KullaniciLogin");

        }


    }
}