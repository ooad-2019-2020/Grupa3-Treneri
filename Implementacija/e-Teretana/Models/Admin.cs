using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Admin : Korisnik
    {
        private bool prijavljen;
        public Admin(string ime, string prezime, string eMail, string korisnickoIme, string sifra, bool prijavljen) : base(ime, prezime, eMail, korisnickoIme, sifra)
        {
            Prijavljen = prijavljen;
        }

        public Admin(DbKorisnik dbKorisnik, DbAdmin dbAdmin) : base(dbKorisnik)
        {
            Prijavljen = dbAdmin.Prijavljen;
        }

        public bool Prijavljen { get => prijavljen; set => prijavljen = value; }
    }
}
