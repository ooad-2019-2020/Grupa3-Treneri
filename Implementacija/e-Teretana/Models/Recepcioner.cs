using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Recepcioner : Korisnik
    {
        public Recepcioner(string ime, string prezime, string eMail, string korisnickoIme, string sifra, DateTime pocetakRadnogVremena, DateTime krajRadnogVremena) : base (ime, prezime, eMail, korisnickoIme, sifra)
        {
            PocetakRadnogVremena = pocetakRadnogVremena;
            KrajRadnogVremena = krajRadnogVremena;
        }

        public DateTime PocetakRadnogVremena { get; set; }
        public DateTime KrajRadnogVremena { get; set; }
    }
}
