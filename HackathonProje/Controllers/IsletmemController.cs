using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackathonProje.Models.Entity;

namespace HackathonProje.Controllers
{
    public class IsletmemController : Controller
    {
        // GET: Isletmem
        hackhathonP01Entities3 db = new hackhathonP01Entities3();
        public ActionResult Index(long isletmeId=1)
        {
            var isletmeBilgiler = db.tblIsletme.ToList().Find(k => k.isletmeId == isletmeId);
             ViewBag.isletmeId = isletmeId;
           ViewBag.isletmeAdi = isletmeBilgiler.isletmeAdi;
            ViewBag.isletmeAciklama = isletmeBilgiler.aciklama;
            ViewBag.isletmeAdres = isletmeBilgiler.adres;
            
            return View();
        }

    }
}