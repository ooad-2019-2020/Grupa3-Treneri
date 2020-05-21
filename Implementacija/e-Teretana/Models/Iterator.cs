using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Iterator : IIterator 
    {
        private List<Clan> prijavljeniClanovi;
        private int index;
        public Iterator(List<Clan> clanovi, int pozicija)
        {
            prijavljeniClanovi = clanovi;
            index = pozicija;
        }

        public Clan dajSljedeci()
        {
            return prijavljeniClanovi[index++];
        }

        public bool imaJos()
        {
            return index < prijavljeniClanovi.Count;
        }
    }
}
