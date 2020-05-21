using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Admin : Korisnik
    {
        public Admin(string ime, string prezime, string eMail, string korisnickoIme, string sifra, bool prijavljen) : base(ime, prezime, eMail, korisnickoIme, sifra)
        {
            Prijavljen = prijavljen;
        }

        public bool Prijavljen { get; set; }
    }
}
