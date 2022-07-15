using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace cv.Models.Siniflar
{
    public class Context :DbContext
    {
        public DbSet<Anasayfa> Anasayfas { get; set; }
        public DbSet<Calismalarim> Calismalarims { get; set; }
        public DbSet<Iletisim> Iletisims { get; set; }
        public DbSet<Hakkimda> Hakkimdas { get; set; }
        public DbSet<Profil> Profils { get; set; }
        public DbSet<Mesaj> Mesajs { get; set; }
        

    }
}