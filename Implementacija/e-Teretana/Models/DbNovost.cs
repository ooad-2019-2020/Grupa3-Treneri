using System;

namespace e_Teretana.Models
{
    public class DbNovost
    {
        public int DbNovostID { get; set; }
        public string Naslov { get; set; }
        public string Tekst { get; set; }
        public string Slika { get; set; }
        public DateTime VrijemeDodavanja { get; set; }
    }
}