using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cv.Models.Siniflar;
namespace cv.Controllers
{
    public class CalismalarimController : Controller
    {
        Context c = new Context();

        // GET: Calismalarim
        public ActionResult Index()
        {

            var degerler = c.Calismalarims.Where(x=>x.PopulerFoto==true).ToList();

            return View(degerler);
        }
    }
}