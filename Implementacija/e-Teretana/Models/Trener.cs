using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Trener : Korisnik
    {
        private List<DbOcjena> ocjene;
        public Trener(string ime, string prezime, string eMail, string korisnickoIme, string sifra) : base(ime, prezime, eMail, korisnickoIme, sifra)
        {
        }

        public List<DbOcjena> Ocjene { get => ocjene; set => ocjene = value; }
        public void dodajOcjenu(int ocjena, DateTime datum)
        {
            DbOcjena novaOcjena= new DbOcjena();
            novaOcjena.Ocjena = ocjena;
            novaOcjena.DatumOcjenjivanja = datum;
            novaOcjena.DbOcjenaID = 0;
            Ocjene.Add(novaOcjena);
        }

        public double dajOcjenuZaMjesec(int mjesec)
        {
            return Ocjene.Where(ocjena => ocjena.DatumOcjenjivanja.Month.Equals(mjesec)).Sum(ocjena => ocjena.Ocjena) / Ocjene.Where(ocjena => ocjena.DatumOcjenjivanja.Month.Equals(mjesec)).Count();
        }
    }
}
