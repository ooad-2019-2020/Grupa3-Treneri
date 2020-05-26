using System;
using System.ComponentModel.DataAnnotations;

namespace e_Teretana.Models
{
    public class DbNovost
    {
        [ScaffoldColumn(false)]
        public int DbNovostID { get; set; }
        [Required]
        public string Naslov { get; set; }
        [Required]
        public string Tekst { get; set; }
        [Required]
        public string Slika { get; set; }
        public DateTime VrijemeDodavanja { get; set; }
    }
}