using cv.Models.Siniflar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cv.Controllers
{
    public class AnasayfaController : Controller
    {
        Context c = new Context();
        // GET: Anasayfa
        public ActionResult Index()
        {
            var degerler = c.Hakkimdas.ToList();
            return View(degerler);
        }

        public PartialViewResult Profil()
        {
            var degerler = c.Profils.ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Yeteneklerim()
        {
            var degerler = c.Anasayfas.Where(x => x.YetenekDurum == true).ToList();
            return PartialView(degerler);
        }
    }
}