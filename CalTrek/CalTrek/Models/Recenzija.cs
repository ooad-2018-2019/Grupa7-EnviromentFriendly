using CalTrekApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalTrek.Models
{
    public class Recenzija
    {
        public Klijent Klijent { get; set; }
        public Strucnjak Strucnjak { get; set; }
        public int Ocjena { get; set; }
        public String Komentar { get; set; }
    }
}
