using System;
using System.Collections.Generic;

namespace e_Teretana.Models
{
    public class DbTrening
    {
        public int DbTreningID { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public int Kapacitet { get; set; }
        public string Opis { get; set; }
        public virtual ICollection<DbKorisnik> PrijavljeniClanovi { get; set; }
        public TipTreninga Tip { get; set; }
        public virtual DbKorisnik Trener { get; set; }
    }
}