using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class DbAdmin
    {
        [ScaffoldColumn(false)]
        public int DbAdminID { get; set; }
        public bool Prijavljen { get; set; }
    }
}
