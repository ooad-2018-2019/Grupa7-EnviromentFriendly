using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalTrekApp.Models
{
    public class Tjelovjezba
    {
        public Tjelovjezba(string naziv, float bCPM)
        {
            Naziv = naziv;
            BCPM = bCPM;
        }

        public int Id { get; set; }

        public string Naziv
        {
            get; set;
        }

        public float BCPM
        {
            get; set;
        }
    }
}