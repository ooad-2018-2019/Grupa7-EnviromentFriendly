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

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        public string Username
        {
            get; set;
        }

        [Required]
        public string Ime
        {
            get; set;
        }

        [Required]
        public string Prezime
        {
            get; set;
        }

        [Required]
        public DateTime DatumRodjenja
        {
            get; set;
        }

        [Required]
        public char Spol
        {
            get; set;
        }

        [Required]
        public string Grad { get; set; }

        [Required]
        public string Drzava { get; set; }
    }
}