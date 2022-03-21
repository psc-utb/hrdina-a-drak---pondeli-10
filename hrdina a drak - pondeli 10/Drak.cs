using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdina_a_drak___pondeli_10
{
    public class Drak : Postava
    {
        
        public Drak(string jmeno, double zdravi, double zdraviMax, double poskozeniMax, double zbrojMax) : base(jmeno, zdravi, zdraviMax, poskozeniMax, zbrojMax)
        {
        }

        protected override bool KontrolaOponenta(Postava oponent)
        {
            return oponent is not Drak;
        }
    }
}
