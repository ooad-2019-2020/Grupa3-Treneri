using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Trening : IIterableCollection
    {
        public DateTime DatumOdrzavanja { get; set; }
        public int Kapacitet { get; set; }
        public string Opis { get; set; }
        public List<Clan> PrijavljeniClanovi { get; set; }
        public TipTreninga Tip { get; set; }
        public Trener trener { get; set; }

        private Iterator iterator;

        public Iterator kreirajIterator()
        {
            return new Iterator(PrijavljeniClanovi, 0);
        }
        public void prijaviClana (Clan clan)
        {
            PrijavljeniClanovi.Add(clan);
        }
    }
}
