using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdina_a_drak___pondeli_10
{
    public class Bedna : IZasazitelny
    {
        public double Zdravi { get; set; }
        public int Odolnost { get; set; }

        public Bedna(double zdravi, int odolnost)
        {
            Zdravi = zdravi;
            Odolnost = odolnost;
        }

        public double Obrana()
        {
            return Odolnost;
        }

        public bool JeRozbita()
        {
            if (Zdravi <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
