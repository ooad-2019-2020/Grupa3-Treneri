using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Clan : Korisnik
    {
        public Clan(string ime, string prezime, string eMail, string korisnickoIme, string sifra, TipClanarine clanarina, DateTime datumUclanjivanja, int brojPosjeta, bool trenutnoPrisutan, IPlanIshrane planIshrane) : base(ime, prezime, eMail, korisnickoIme, sifra)
        {
            Clanarina = clanarina;
            DatumUclanjivanja = datumUclanjivanja;
            BrojPosjeta = brojPosjeta;
            TrenutnoPrisutan = trenutnoPrisutan;
            PlanIshrane = planIshrane;
        }

        public TipClanarine Clanarina { get; set; }
        public DateTime DatumUclanjivanja { get; set; }
        public int BrojPosjeta { get; set; }
        public bool TrenutnoPrisutan { get; set; }
        public IPlanIshrane PlanIshrane { get; set; }
       

    }
}
