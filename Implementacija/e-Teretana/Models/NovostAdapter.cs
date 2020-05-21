using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class NovostAdapter : IDodavanjeNovosti
    {
        public void dodajTreningNovost(Trening trening)
        {
            //kreira se nova novost i pozove metoda teretane za dodavanje te novosti
            Teretana.getInstance().dodajNovost(new Novost("", "", "", DateTime.Now));
        }
    }
}
