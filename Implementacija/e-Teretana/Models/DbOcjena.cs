using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class DbOcjena
    {
        [ScaffoldColumn(false)]
        public int DbOcjenaID { get; set; }
        public DateTime DatumOcjenjivanja { get; set; }
        [Required]
        public int Ocjena { get; set; }

    }
}
