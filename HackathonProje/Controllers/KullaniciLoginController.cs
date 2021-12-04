using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HackathonProje.Models.Entity;

namespace HackathonProje.Controllers
{
    public class KullaniciLoginController : Controller
    {


        hackhathonP01Entities3 db = new hackhathonP01Entities3();

        // GET: KullaniciLogin

        public ActionResult Index(string email,string sifre)
        {

            ViewBag.log = Session["kullaniciId"] is null;
            if (!(Session["kullaniciId"] is null))
            {
                // return RedirectToRoute("https://localhost:44359/KodViewer/Index");
                return Redirect("https://localhost:44359/KodViewer/Index");
            }

            var kullanicilar = db.tblKullanici.ToList();

            var kullanici = kullanicilar.Find(k => k.email == email && k.parola == sifre);
            if (kullanici!=null)
            {
                Session["kullaniciId"] = kullanici.kullaniciId;
                Session["email"] = kullanici.email;

                var kullaniciIsletme = db.tblIsletmeKullanici.ToList().Find(i => i.kullaniciId == kullanici.kullaniciId);
                if(kullaniciIsletme !=null)
                {
                    Session["isletmeId"] = kullaniciIsletme.isletmeId;
                }
                return Redirect("https://localhost:44359/KodViewer/Index");

            }



            return View();
        }
    }
}