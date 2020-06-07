using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class DbClanTrening
    {
        public DbClanTrening(int dbClanID, int dbTreningID)
        {
            DbClanID = dbClanID;
            DbTreningID = dbTreningID;
        }

        public int DbClanID { get; set; }
        public DbClan DbClan { get; set; }

        public int DbTreningID { get; set; }
        public DbTrening DbTrening { get; set; }
    }
}
