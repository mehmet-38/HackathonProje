using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using QRCoder;

namespace HackathonProje.Controllers
{
    public class KullaniciController : Controller
    {
       
        public ActionResult Index(string kuponKod="nun")
        {
            ViewBag.KullaniciId = Session["kullaniciId"];
            ViewBag.KuponKod = kuponKod;

            string uri = "https://localhost:44359/IsletmeciKodOnay/Index?musteriId="+ViewBag.KullaniciId+"&kuponKod=" + kuponKod;

            using (MemoryStream ms = new MemoryStream())
            {
                QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
                QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(uri, QRCodeGenerator.ECCLevel.Q);
                QRCode qRCode = new QRCode(qRCodeData);

                using (Bitmap bitmap = qRCode.GetGraphic(20))
                {
                    bitmap.Save(ms, ImageFormat.Png);
                    ViewBag.QRCodeImage = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());

                }
            }

            return View();
        }
      


    }
}