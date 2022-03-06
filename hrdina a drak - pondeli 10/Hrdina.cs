using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdina_a_drak___pondeli_10
{
    public class Hrdina : Postava
    {

        public Mec Mec { get; set; }

        public Hrdina(string jmeno, double zdravi, double zdraviMax, double poskozeniMax, double zbrojMax, Mec mec) : base(jmeno, zdravi, zdraviMax, poskozeniMax, zbrojMax)
        {
            Mec = mec;
        }

        public new double Utok(Postava oponent)
        {
            if (Mec != null)
            {
                return UtokGenerovani(oponent, Mec.PoskozeniMax);
            }
            else
            {
                return UtokGenerovani(oponent, PoskozeniMax);
            }
        }

    }
}
