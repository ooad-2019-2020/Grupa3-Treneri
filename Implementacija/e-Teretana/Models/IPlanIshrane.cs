using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace e_Teretana.Models
{
    public interface IPlanIshrane
    {
        public string dajPlanIshraneZaPonedjeljak();
        public string dajPlanIshraneZaUtorak();
        public string dajPlanIshraneZaSrijedu();
        public string dajPlanIshraneZaCetvrtak();
        public string dajPlanIshraneZaPetak();
        public string dajPlanIshraneZaSubotu();
        public string dajPlanIshraneZaNedjelju();
    }
}
