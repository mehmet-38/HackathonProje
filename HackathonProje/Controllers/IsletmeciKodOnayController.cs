using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackathonProje.Models.Entity;

namespace HackathonProje.Controllers
{
    public class IsletmeciKodOnayController : Controller
    {
        // GET: IsletmeciKodOnay
        
       
        hackhathonP01Entities3 db = new hackhathonP01Entities3();
        public ActionResult Index(long musteriId=0, string kuponKod="nun")
        {
            if(Session["isletmeId"] is null)
            {
                return Redirect("~/KullaniciLogin");
            }
            
            var kuponlar = db.tblKuponlarim.ToList();
            var kupon = kuponlar.Find(k => k.kuponKod == Convert.ToInt64(kuponKod) && k.kullaniciId == musteriId);
            ViewBag.musteriId = musteriId;
            if (kupon != null)
            {
                var kullanici = db.tblKullanici.ToList().Find(k => k.kullaniciId == musteriId);

                ViewBag.musteriAdi = kullanici.ad + " " + kullanici.soyad;
                ViewBag.kuponKod = kupon.kuponKod;
                ViewBag.gecerliKod =
                    kupon.isletmeId == Convert.ToInt64(Session["isletmeId"])
                    ? "Geçerli" : "Geçersiz";

                ViewBag.indirimMiktari = kupon.indirim;
                ViewBag.gelisSayisi = 12; //-------------
            }
            return View();
        }
    }
}