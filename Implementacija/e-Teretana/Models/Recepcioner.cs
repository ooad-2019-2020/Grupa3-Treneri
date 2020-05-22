using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Recepcioner : Korisnik
    {
        private DateTime pocetakRadnogVremena, krajRadnogVremena;
        public Recepcioner(string ime, string prezime, string eMail, string korisnickoIme, string sifra, DateTime pocetakRadnogVremena, DateTime krajRadnogVremena) : base(ime, prezime, eMail, korisnickoIme, sifra)
        {
            PocetakRadnogVremena = pocetakRadnogVremena;
            KrajRadnogVremena = krajRadnogVremena;
        }

        public Recepcioner (DbKorisnik dbKorisnik, DbRecepcioner dbRecepcioner) : base(dbKorisnik)
        {
            PocetakRadnogVremena = dbRecepcioner.PocetakRadnogVremena;
            KrajRadnogVremena = dbRecepcioner.KrajRadnogVremena;
        }

        public DateTime PocetakRadnogVremena { get => pocetakRadnogVremena; set => pocetakRadnogVremena = value; }
        public DateTime KrajRadnogVremena { get => krajRadnogVremena; set => krajRadnogVremena = value; }
    }
}
