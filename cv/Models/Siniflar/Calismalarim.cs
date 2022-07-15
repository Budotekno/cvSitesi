using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cv.Models.Siniflar
{
    public class Calismalarim
    {
        [Key]
        public int Id { get; set; }
        public string FotoUrl { get; set; }
        public bool PopulerFoto { get; set; }
        public bool Durum { get; set; }

    }
}