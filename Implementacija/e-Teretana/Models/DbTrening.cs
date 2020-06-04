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
        public virtual List<DbClanTrening> PrijavljeniClanovi { get; set; }
        [Required]
        public TipTreninga Tip { get; set; }
        [Required]
        public int DbTrenerID { get; set; }
    }
}