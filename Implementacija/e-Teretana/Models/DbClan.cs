﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class DbClan
    {
        [ScaffoldColumn(false)]
        public int DbClanID {get; set; }
        [Required]
        public TipClanarine Clanarina { get; set; }
        public DateTime DatumUclanjivanja { get; set; }
        public int BrojPosjeta { get; set; }
        public bool TrenutnoPrisutan { get; set; }
    }
}
