using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdina_a_drak___pondeli_10
{
    public class Mec
    {
        public double PoskozeniMax { get; set; }

        public Mec(double poskozeniMax)
        {
            PoskozeniMax = poskozeniMax;
        }

        public Mec Clone()
        {
            //Mec mec = new Mec(this.PoskozeniMax);
            Mec mec = this.MemberwiseClone() as Mec;
            return mec;
        }
    }
}
