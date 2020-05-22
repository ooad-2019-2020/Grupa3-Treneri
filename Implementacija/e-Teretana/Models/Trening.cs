using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Trening
    {
        public Trening(DateTime datumOdrzavanja, int kapacitet, string opis, List<Clan> prijavljeniClanovi, TipTreninga tip, Trener trener)
        {
            DatumOdrzavanja = datumOdrzavanja;
            Kapacitet = kapacitet;
            Opis = opis;
            PrijavljeniClanovi = prijavljeniClanovi;
            Tip = tip;
            Trener = trener;
        }

        public Trening(DbTrening dbTrening)
        {
            DatumOdrzavanja = dbTrening.DatumOdrzavanja;
            Kapacitet = dbTrening.Kapacitet;
            Opis = dbTrening.Opis;
            //PrijavljeniClanovi = (List<Clan>)dbTrening.PrijavljeniClanovi;
            Tip = dbTrening.Tip;
            //Trener = dbTrening.Trener;
        }

        public DateTime DatumOdrzavanja { get; set; }
        public int Kapacitet { get; set; }
        public string Opis { get; set; }
        public List<Clan> PrijavljeniClanovi { get; set; }
        public TipTreninga Tip { get; set; }
        public Trener Trener { get; set; }


        public Iterator kreirajIterator()
        {
            return new Iterator(PrijavljeniClanovi, 0);
        }
        public void prijaviClana(Clan clan)
        {
            PrijavljeniClanovi.Add(clan);
        }
    }
}
