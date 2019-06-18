using CalTrekApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalTrek.Models
{
    public class FizickeKarakteristike
    {
        public Korisnik Korisnik { get; set; }

        public Double Visina { get; set; }
        public Double Tezina { get; set; }
        public Double ProcenatMasnoce { get; set; }
        public Double BMR { get; set; }

        public int Aktivnost { get; set; }
        public int Cilj { get; set; }
    }
}
