using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace cv.Models.Siniflar
{
    public class Hakkimda
    {

        [Key]
        public int Id { get; set; }
        public string HakkimdaFotoUrl { get; set; }
        public string HakkimdaYazi { get; set; }
    }
}