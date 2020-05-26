using System.ComponentModel.DataAnnotations;

namespace e_Teretana.Models
{
    public class DbKorisnik
    {
        [ScaffoldColumn(false)]
        public int DbKorisnikID { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [Required]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        public string EMail { get; set; }
        [Required]
        public string KorisnickoIme { get; set; }
        [Required]
        public string Sifra { get; set; }
    }
}