using CalTrekApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalTrek.Models
{
    public class KorisnikObrok
    {
        public Klijent Klijent { get; set; }
        public Obrok Obrok { get; set; }
        public DateTime DatumUnosa { get; set; }
    }
}
