using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cv.Models.Siniflar;

namespace cv.Controllers
{
    public class IletisimController : Controller
    {
        Context c = new Context();
        // GET: Iletisim
        public ActionResult Index()
        {
            var degerler = c.Iletisims.ToList();
            return View(degerler);
        }

        public ActionResult MesajGonder(Mesaj m)
        {
            c.Mesajs.Add(m);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}