using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cv.Models.Siniflar
{
    public class Anasayfa
    {
        [Key]
        public int Id { get; set; }
        public string YetenekIsim { get; set; }
        public string YetenekDeger { get; set; }
        public bool YetenekDurum { get; set; }
    }
}