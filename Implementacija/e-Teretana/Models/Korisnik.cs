using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public abstract class Korisnik
    {
        protected Korisnik(string ime, string prezime, string eMail, string korisnickoIme, string sifra)
        {
            Ime = ime;
            Prezime = prezime;
            EMail = eMail;
            KorisnickoIme = korisnickoIme;
            Sifra = sifra;
        }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string EMail { get; set; }
        public string KorisnickoIme { get; set; }
        public string Sifra { get; set; }
    }
}
