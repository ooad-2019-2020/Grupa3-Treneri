using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class ProxyOprema : IOprema
    {
        private List<Oprema> oprema=new List<Oprema>();
        private bool dozvola;

        public ProxyOprema()
        {
            //dobaviti listu iz baze
            dozvola = false;
        }
        public void pristupi (Clan clan, bool zauzimanje)
        {
            if (zauzimanje == false)
            {
                dozvola = true;
                return;
            }
            if (clan.TrenutnoPrisutan == true)
            {
                dozvola = true;
            }
            else
            {
                dozvola = false;
            }
        }

        public void dodajOpremu (Oprema novaOprema)
        {
            oprema.Add(novaOprema);
        }
        public List<string> dajIzvjestaj(TipZauzetostiOpreme tip)
        {
            List<string> izvjestaj = new List<string>();
            foreach (Oprema o in oprema)
            {
                if (tip.Equals(TipZauzetostiOpreme.SLOBODNO) && o.TipZauzetosti.Equals(tip))
                {
                    izvjestaj.Add(o.NazivOpreme + "    " + o.Sifra);
                }
                else if ((tip.Equals(TipZauzetostiOpreme.ZAUZETO) || tip.Equals(TipZauzetostiOpreme.IZNAJMLJENO) && o.TipZauzetosti.Equals(tip)))
                {
                    izvjestaj.Add(o.NazivOpreme + "    " + o.Sifra + "    " + o.KorisnikOpreme.KorisnickoIme + "    " + o.KrajnjiDatum);
                }
            }
            return izvjestaj;
        }

        public List<string> dajIzvjestaj()
        {
            List<string> izvjestaj = new List<string>();
            foreach (Oprema o in oprema)
            {
                    izvjestaj.Add(o.ToString());
            }
            return izvjestaj;
        }

        public List<string> dajIzvjestajZaClana (Clan clan)
        {
            List<string> izvjestaj = new List<string>();
            foreach (Oprema o in oprema)
            {
                if (o.KorisnikOpreme!=null && o.KorisnikOpreme.KorisnickoIme.Equals(clan.KorisnickoIme))
                {
                    izvjestaj.Add(o.ToString());
                }
            }
            return izvjestaj;
        }

        public Oprema dajOpremu(int sifraOpreme)
        {
            if (dozvola == true)
            {
                return oprema.Find(oprema => oprema.Sifra == sifraOpreme);
            }
            return null;
        }
        
        
    }
}

