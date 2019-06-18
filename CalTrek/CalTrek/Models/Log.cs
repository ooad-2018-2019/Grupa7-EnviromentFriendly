using CalTrekApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalTrek.Models
{
    public class Log
    {
        public int Log_ID { get; set; }
        public Korisnik Korisnik { get; set; }
        public String IzmijenjenaKolona { get; set; }
        public Double NovaVrijednost { get; set; }
        public DateTime DatumPromjene { get; set; }

    }

}
