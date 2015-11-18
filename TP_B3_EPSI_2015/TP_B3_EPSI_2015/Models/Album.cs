using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP_B3_EPSI_2015.Models
{
    public class Album
    {
        public int id { get; set; }
        public string titre { get; set; }
        public string auteur { get; set; }
        public string genre { get; set; }
        public int annee_sortie { get; set; }


    }
}