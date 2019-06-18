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

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        public string Naziv
        {
            get; set;
        }

        [Required]
        public float BCPM
        {
            get; set;
        }
    }
}