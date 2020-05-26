using System;
using System.ComponentModel.DataAnnotations;

namespace e_Teretana.Models
{
    public class DbOprema
    {
        [ScaffoldColumn(false)]
        public int DbOpremaID { get; set; }
        [Required]
        public string NazivOpreme { get; set; }
        [Required]
        public TipZauzetostiOpreme TipZauzetosti { get; set; }
        [Required]
        public string Opis { get; set; }
        public bool NaCekanju { get; set; }
        public DateTime PocetniDatum { get; set; }
        public DateTime KrajnjiDatum { get; set; }
        public virtual DbKorisnik KorisnikOpreme { get; set; }
        [Required]
        public int Sifra { get; set; }
    }
}