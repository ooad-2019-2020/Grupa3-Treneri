using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Novost : INovost
    {
        private string naslov, tekst, slika;
        private DateTime vrijemeDodavanja;
        public Novost(string naslov, string tekst, string slika, DateTime vrijemeDodavanja)
        {
            Naslov = naslov;
            Tekst = tekst;
            Slika = slika;
            VrijemeDodavanja = vrijemeDodavanja;
        }

        public string Naslov { get => naslov; set => naslov=value; }
        public string Tekst { get => tekst; set => tekst=value; }
        public string Slika { get => slika; set => slika=value; }
        public DateTime VrijemeDodavanja { get =>vrijemeDodavanja; set => vrijemeDodavanja=value; }

        public Novost clone()
        {
            return new Novost(Naslov, Tekst, Slika, DateTime.Now); //dodati defaultnu sliku kad spojimo sa bazom
        }
    }
}
