using CalTrekApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalTrek.Models
{
    public class Zahtjev
    {
        public Klijent Klijent { get; set; }
        public Strucnjak Strucnjak { get; set; }

        public DateTime PocetniDatum { get; set; }
        public DateTime KrajnjiDatum { get; set; }
    }
}
