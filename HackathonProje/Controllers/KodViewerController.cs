using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackathonProje.Models.Entity;

namespace HackathonProje.Controllers
{
    public class KodViewerController : Controller
    {
        // GET: KodViewer
        hackhathonP01Entities3 db = new hackhathonP01Entities3();
        public ActionResult Index()
        {
            var kuponlar = db.tblKuponlarim.ToList().FindAll(k=> k.kullaniciId == Convert.ToInt64(Session["kullaniciId"]));
            if(Session["kullaniciId"] is null)
            {
                return Redirect("~/KullaniciLogin");
            }
            ViewBag.email = Session["email"];
            return View(kuponlar);
        }

        public ActionResult KuponAl()
        {
            var kuponlarim = db.tblKuponlarim.ToList().FindAll(k => k.kullaniciId == Convert.ToInt64(Session["kullaniciId"]));
            var alinabilirKuponlar =
                db.tblKuponlar.ToList().FindAll(
                    k => kuponlarim.Any(j=> j.kuponKod == k.kuponKod) == false
                    );

                return View(alinabilirKuponlar);
        }

        [HttpPost]
        public ActionResult KuponKaydet(string kuponKod)
        {
            var tiklananKupon = db.tblKuponlar.ToList().Find(k => k.kuponKod == Convert.ToInt64(kuponKod));
            tblKuponlarim kuponum = new tblKuponlarim();
            kuponum.kuponKod = tiklananKupon.kuponKod;
            kuponum.isletmeId = tiklananKupon.isletmeId;
            kuponum.indirim = tiklananKupon.indirim;
            kuponum.kullaniciId = Convert.ToInt64(Session["kullaniciId"]);
            
            db.tblKuponlarim.Add(kuponum);
            db.SaveChanges();
            TempData["alindi"] = "True";
         
            return RedirectToAction("KuponAl");
        }
        public ActionResult YorumYap(long isletmeId)
        {
            var isletme = db.tblIsletme.ToList().Find(i => i.isletmeId == isletmeId);
            TempData["isletmeAdi"] = isletme.isletmeAdi;
            return View(isletme);
        }

    }
}