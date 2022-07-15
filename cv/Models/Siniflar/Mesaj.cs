using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cv.Models.Siniflar
{
    public class Mesaj
    {
        [Key]
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }

        


    }
}