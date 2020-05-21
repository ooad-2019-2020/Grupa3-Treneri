using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Novost : INovost
    {
        public Novost(string naslov, string tekst, string slika, DateTime trenutnoVrijeme)
        {
            Naslov = naslov;
            Tekst = tekst;
            Slika = slika;
            TrenutnoVrijeme = trenutnoVrijeme;
        }

        public string Naslov { get; set; }
        public string Tekst { get; set; }
        public string Slika { get; set; }
        public DateTime TrenutnoVrijeme { get; set; }

        public Novost clone()
        {
            return new Novost(Naslov, Tekst, Slika, DateTime.Now);
        }
    }
}
