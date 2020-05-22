using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Iterator : IIterator 
    {
        private ICollection<Clan> prijavljeniClanovi;
        private int index;
        public Iterator(ICollection<Clan> clanovi, int pozicija)
        {
            prijavljeniClanovi = clanovi;
            index = pozicija;
        }

        public Clan dajSljedeci()
        {
            return prijavljeniClanovi.ElementAt(index++);
        }

        public bool imaJos()
        {
            return index < prijavljeniClanovi.Count;
        }
    }
}
