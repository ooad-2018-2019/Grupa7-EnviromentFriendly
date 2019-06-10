using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalTrekApp.Models
{
    public abstract class Korisnik
    {
        public Korisnik(string username, string ime, string prezime, char spol, DateTime datumRodjenja, string grad, string drzava)
        {
            Username = username;
            Ime = ime;
            Prezime = prezime;
            Spol = spol;
            DatumRodjenja = datumRodjenja;
            Grad = grad;
            Drzava = drzava;
        }

        public int Id { get; set; }

        public string Username
        {
            get; set;
        }

        public string Ime
        {
            get; set;
        }

        public string Prezime
        {
            get; set;
        }

        public DateTime DatumRodjenja
        {
            get; set;
        }

        public char Spol
        {
            get; set;
        }

        public string Grad { get; set; }

        public string Drzava { get; set; }
    }
}