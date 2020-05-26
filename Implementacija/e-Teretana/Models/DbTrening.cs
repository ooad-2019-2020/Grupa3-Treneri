using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_Teretana.Models
{
    public class DbTrening
    {
        [ScaffoldColumn(false)]
        public int DbTreningID { get; set; }
        [Required]
        public DateTime DatumOdrzavanja { get; set; }
        [Required]
        public int Kapacitet { get; set; }
        [Required]
        public string Opis { get; set; }
        public virtual ICollection<DbKorisnik> PrijavljeniClanovi { get; set; }
        [Required]
        public TipTreninga Tip { get; set; }
        [Required]
        public virtual DbKorisnik Trener { get; set; }
    }
}