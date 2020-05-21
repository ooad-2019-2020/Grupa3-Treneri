using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Trener : Korisnik
    {
        public Trener(string ime, string prezime, string eMail, string korisnickoIme, string sifra) : base (ime, prezime, eMail, korisnickoIme, sifra)
        {
        }

        public Dictionary<DateTime, int> Ocjene { get; set; }
        public void dodajOcjenu (int ocjena, DateTime datum)
        {
            Ocjene.Add(datum, ocjena);
        }

        public double dajOcjenuZaMjesec(int mjesec)
        {
            return Ocjene.Where(ocjena => ocjena.Key.Month.Equals(mjesec)).Sum(ocjena => ocjena.Value)/ Ocjene.Where(ocjena => ocjena.Key.Month.Equals(mjesec)).Count();
        }
    }
}
