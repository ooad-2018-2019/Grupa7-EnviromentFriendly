using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalTrekApp.Models
{
    public class Strucnjak : Korisnik
    {
        public Strucnjak(string username, string ime, string prezime, char spol, DateTime datumRodjenja, string grad, string drzava, int godineIskustva, int tip) : base(username, ime, prezime, spol, datumRodjenja, grad, drzava)
        {
            GodineIskustva = godineIskustva;
            Tip = tip;
        }

        [Required]
        public int GodineIskustva
        {
            get; set;
        }

        [Required]
        public int Tip
        {
            get; set;
        }
    }
}