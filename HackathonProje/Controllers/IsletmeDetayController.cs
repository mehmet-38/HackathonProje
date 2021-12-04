using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackathonProje.Models.Entity;

namespace HackathonProje.Controllers
{
    public class IsletmeDetayController : Controller
    {
        // GET: IsletmeDetay
        public hackhathonP01Entities3 db = new hackhathonP01Entities3();
        public ActionResult Index(long isletmeId)
        {
            var isletme = db.tblIsletme.ToList().Find(k => k.isletmeId == isletmeId);
            ViewBag.isletmeId = isletmeId;
            ViewBag.isletmeAdi = isletme.isletmeAdi;
            ViewBag.isletmeAciklama = isletme.aciklama;
            ViewBag.isletmeAdres = isletme.adres;
            ViewBag.isletmePuan = isletme.puan;
            var yorumlar = db.tblPuanDetay.ToList().FindAll(k => k.isletmeId == isletmeId);
            return View(yorumlar);
        }
    }
}