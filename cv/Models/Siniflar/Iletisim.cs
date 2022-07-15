using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cv.Models.Siniflar
{
    public class Iletisim
    {
        [Key]
        public int Id { get; set; }
        public string KonumLink { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string AdresAdi { get; set; }
       

    }
}