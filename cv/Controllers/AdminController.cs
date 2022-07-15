using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using cv.Models.Siniflar;

namespace cv.Controllers
{
    public class AdminController : Controller
    {
        Context c = new Context();
        // GET: Admin
        public ActionResult Index()
        {
            var degerler = c.Anasayfas.Where(x => x.YetenekDurum == true).ToList();
            return View(degerler);
        }

        public PartialViewResult Profil()
        {
            var degerler = c.Profils.ToList();
            return PartialView(degerler);
        }

        public ActionResult ProfilGuncelleSayfasi(int id)
        {
           // var degerler = c.Profils.Find(id);
            
           var degerler = c.Profils.Where(x=>x.Id ==id).ToList();
            return View(degerler);
        }

        public ActionResult ProfilGuncelle(Profil p)
        {
            var degerler = c.Profils.Find(p.Id);
            degerler.ProfilAd = p.ProfilAd;
            degerler.Unvan = p.Unvan;
            degerler.FotoUrl = p.FotoUrl;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YetenekEkleSayfasi()
        {
            return View();
        }

        [HttpGet]
        public ActionResult YetenekEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YetenekEkle(Anasayfa a)
        {
            c.Anasayfas.Add(a);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YetenekSil(int id)
        {
            var degerler = c.Anasayfas.Find(id);
            // c.Anasayfas.Remove(degerler);
            degerler.YetenekDurum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YetenekGuncelleSayfasi(int id)
        {
            var bulunanDegerler = c.Anasayfas.Find(id);
            return View(bulunanDegerler);
        }

        public ActionResult YetenekGuncelle(Anasayfa a)
        {
            var degerler = c.Anasayfas.Find(a.Id);
            degerler.YetenekIsim = a.YetenekIsim;
            degerler.YetenekDeger = a.YetenekDeger;
            c.SaveChanges();
            return RedirectToAction("Index");
        }




        public PartialViewResult Hakkimda()
        {
            var degerler = c.Hakkimdas.ToList();
            return PartialView(degerler);
        }


        public ActionResult HakkimdaGuncelleSayfasi(int id)
        {
            var bululanId = c.Hakkimdas.Find(id);
            return View(bululanId);
        }

        public ActionResult HakkimdaGuncelle(Hakkimda h)
        {
            var degerler = c.Hakkimdas.Find(h.Id);
            degerler.HakkimdaYazi = h.HakkimdaYazi;
            degerler.HakkimdaFotoUrl = h.HakkimdaFotoUrl;
            c.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult Calismalarim()
        {
            var degerler = c.Calismalarims.Where(x=>x.Durum==true).ToList();
            return View(degerler);
        }

        public ActionResult CalismaEkleSayfasi()
        {
            return View();
        }

        public ActionResult CalismaEkle(Calismalarim ca)
        {
            c.Calismalarims.Add(ca);
            c.SaveChanges();
            return RedirectToAction("Calismalarim");
        }

        public ActionResult CalismaSil(int id)
        {
            var silinecekId = c.Calismalarims.Find(id);
            // c.Calismalarims.Remove(silinecekId);
            silinecekId.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Calismalarim");
        }

        public ActionResult CalismaGuncelleSayfasi(int id)
        {
            var bulunanId = c.Calismalarims.Find(id);
            return View(bulunanId);
        }

        public ActionResult CalismaGuncelle(Calismalarim ca)
        {
            var degerler = c.Calismalarims.Find(ca.Id);
            degerler.FotoUrl = ca.FotoUrl;
            c.SaveChanges();
            return RedirectToAction("Calismalarim");
        }

        public ActionResult CalismaSec(int id)
        {
            var bulunanId = c.Calismalarims.Find(id);
            if (bulunanId.PopulerFoto == true)
            {
                bulunanId.PopulerFoto = false;
            }
            else
            {
                bulunanId.PopulerFoto = true;
            }

            c.SaveChanges();

            return RedirectToAction("Calismalarim");
        }

        public ActionResult Iletisim()
        {
            var degerler = c.Iletisims.ToList();
            return View(degerler);
        }

        public ActionResult IletisimGuncelleSayfasi(int id)
        {
            var degerler = c.Iletisims.Where(x => x.Id == id).ToList();
            return View(degerler);
        }

        public ActionResult IletisimGuncelle(Iletisim i)
        {
            var degerler = c.Iletisims.Find(i.Id);
            degerler.Tel = i.Tel;
            degerler.Mail = i.Mail;
            degerler.AdresAdi = i.AdresAdi;
            degerler.KonumLink = i.KonumLink;
            c.SaveChanges();
            return RedirectToAction("Iletisim");
        }

        public PartialViewResult MesajSayfasi()
        {
            var degerler = c.Mesajs.ToList();
            return PartialView(degerler);
        }

        public ActionResult MesajSil(int id)
        {
            var bulunanId = c.Mesajs.Find(id);
            c.Mesajs.Remove(bulunanId);
            c.SaveChanges();
            return RedirectToAction("Iletisim");
        }

        public ActionResult MesajGuncelleSayfasi(int id)
        {
            var degerler = c.Mesajs.Where(x => x.Id == id).ToList();
            
            return View(degerler);
        }

        public ActionResult MesajGuncelle(Mesaj m)
        {
            var degerler = c.Mesajs.Find(m.Id);
            degerler.Isim = m.Isim;
            degerler.Mail = m.Mail;
            degerler.Konu = m.Konu;
            c.SaveChanges();
            return RedirectToAction("Iletisim");

        }
    }
}