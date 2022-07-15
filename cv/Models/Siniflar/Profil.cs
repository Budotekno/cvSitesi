using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cv.Models.Siniflar
{
    public class Profil
    {
        [Key]
        public int Id { get; set; }
        public string ProfilAd { get; set; }
        public string Unvan { get; set; }
        public string FotoUrl { get; set; }

    }
}