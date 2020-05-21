using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public class ProxyOprema : IOprema
    {
        private List<Oprema> Oprema;
        private bool dozvola;
        public void pristupi (Clan clan, bool zauzimanje)
        {

        }

        public void dodajOpremu (Oprema oprema)
        {
            Oprema.Add(oprema);
        }
        public List<string> dajIzvjestaj()
        {
            return null;
        }
    }
}
