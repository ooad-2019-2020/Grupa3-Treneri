using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Clan : Korisnik
    {
        private TipClanarine clanarina;
        private DateTime datumUclanjivanja;
        private int brojPosjeta;
        private bool trenutnoPrisutan;
        private IPlanIshrane planIshrane;
        public Clan(string ime, string prezime, string eMail, string korisnickoIme, string sifra, TipClanarine clanarina, DateTime datumUclanjivanja, int brojPosjeta, bool trenutnoPrisutan, IPlanIshrane planIshrane) : base(ime, prezime, eMail, korisnickoIme, sifra)
        {
            Clanarina = clanarina;
            DatumUclanjivanja = datumUclanjivanja;
            BrojPosjeta = brojPosjeta;
            TrenutnoPrisutan = trenutnoPrisutan;
            PlanIshrane = planIshrane;
        }

        public Clan (DbKorisnik dbKorisnik, DbClan dbClan) : base(dbKorisnik)
        {
            Clanarina = dbClan.Clanarina;
            DatumUclanjivanja = dbClan.DatumUclanjivanja;
            BrojPosjeta = dbClan.BrojPosjeta;
            TrenutnoPrisutan = dbClan.TrenutnoPrisutan;
            PlanIshrane = new PocetnickiPlanIshrane();
        }

        public TipClanarine Clanarina { get => clanarina; set => clanarina = value; }
        public DateTime DatumUclanjivanja { get => datumUclanjivanja; set => datumUclanjivanja = value; }
        public int BrojPosjeta { get => brojPosjeta; set => brojPosjeta = value; }
        public bool TrenutnoPrisutan { get => trenutnoPrisutan; set => trenutnoPrisutan = value; }
        public IPlanIshrane PlanIshrane { get => planIshrane; set => planIshrane = value; }

    }
}
