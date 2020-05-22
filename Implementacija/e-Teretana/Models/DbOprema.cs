using System;

namespace e_Teretana.Models
{
    public class DbOprema
    {
        public int DbOpremaID { get; set; }
        public string NazivOpreme { get; set; }
        public TipZauzetostiOpreme TipZauzetosti { get; set; }
        public string Opis { get; set; }
        public bool NaCekanju { get; set; }
        public DateTime PocetniDatum { get; set; }
        public DateTime KrajnjiDatum { get; set; }
        public virtual DbKorisnik KorisnikOpreme { get; set; }
        public int Sifra { get; set; }
    }
}