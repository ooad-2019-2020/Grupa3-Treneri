using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class Oprema : IOprema
    {
        public Oprema(string nazivOpreme, TipZauzetostiOpreme tipZauzetosti, string opis, bool naCekanju, DateTime pocetniDatum, DateTime krajnjiDatum, Clan korisnikOpreme, int sifra)
        {
            NazivOpreme = nazivOpreme;
            TipZauzetosti = tipZauzetosti;
            Opis = opis;
            NaCekanju = naCekanju;
            PocetniDatum = pocetniDatum;
            KrajnjiDatum = krajnjiDatum;
            KorisnikOpreme = korisnikOpreme;
            Sifra = sifra;
        }

        public string NazivOpreme { get; set; }
        public TipZauzetostiOpreme TipZauzetosti { get; set; }
        public string Opis { get; set; }
        public bool NaCekanju { get; set; }
        public DateTime PocetniDatum { get; set; }
        public DateTime KrajnjiDatum { get; set; }
        public Clan KorisnikOpreme { get; set; }
        public int Sifra { get; set; }
    }
}
