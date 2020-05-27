using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class DbTrener
    {
      
        public int DbTrenerID { get; set; }
        public ICollection<DbOcjena> ocjene { get; set; }
    }
}
