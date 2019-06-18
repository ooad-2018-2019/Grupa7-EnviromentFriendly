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

        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Required]
        public string Naziv
        {
            get; set;
        }

        [Required]
        public float Proteini
        {
            get; set;
        }

        [Required]
        public float Ugljikohidrati
        {
            get; set;
        }

        [Required]
        public float Masti
        {
            get; set;
        }

        [Required]
        public float Kalorije
        {
            get; set;
        }


    }
}