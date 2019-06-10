using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalTrekApp.Models
{
    public class Klijent : Korisnik
    {
        public Klijent(string username, string ime, string prezime, char spol, DateTime datumRodjenja, string grad, string drzava) : base(username, ime, prezime, spol, datumRodjenja, grad, drzava) { }
    }
}