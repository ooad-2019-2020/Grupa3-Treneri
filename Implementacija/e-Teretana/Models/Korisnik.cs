using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public abstract class Korisnik
    {
        private string ime, prezime, eMail, korisnickoIme, sifra;
        public Korisnik(string ime, string prezime, string eMail, string korisnickoIme, string sifra)
        {
            Ime = ime;
            Prezime = prezime;
            EMail = eMail;
            KorisnickoIme = korisnickoIme;
            Sifra = sifra;
        }

        public Korisnik (DbKorisnik dbKorisnik)
        {
            Ime = dbKorisnik.Ime;
            Prezime = dbKorisnik.Prezime;
            EMail = dbKorisnik.EMail;
            KorisnickoIme = dbKorisnik.EMail;
            Sifra = dbKorisnik.Sifra;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string EMail { get => eMail; set => eMail = value; }
        public string KorisnickoIme { get => korisnickoIme; set => korisnickoIme = value; }
        public string Sifra { get => sifra; set => sifra = value; }

        public override bool Equals(object obj)
        {
            if (obj is Korisnik)
            {
                Korisnik k = (Korisnik)obj;
                return korisnickoIme.Equals(k.korisnickoIme);
            }
            return base.Equals(obj);
        }
    }
}
