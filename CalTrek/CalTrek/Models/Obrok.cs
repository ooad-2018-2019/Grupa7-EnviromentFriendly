using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CalTrekApp.Models
{
    public class Obrok
    {
        public Obrok(string naziv, float proteini, float ugljikohidrati, float masti, float kalorije)
        {
            Naziv = naziv;
            Proteini = proteini;
            Ugljikohidrati = ugljikohidrati;
            Masti = masti;
            Kalorije = kalorije;
        }

        public int Id { get; set; }

        public string Naziv
        {
            get; set;
        }

        public float Proteini
        {
            get; set;
        }

        public float Ugljikohidrati
        {
            get; set;
        }

        public float Masti
        {
            get; set;
        }

        public float Kalorije
        {
            get; set;
        }


    }
}