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

        public Hrdina(string jmeno, double zdraviMax, double poskozeniMax, double zbrojMax) : this(jmeno, zdraviMax, zdraviMax, poskozeniMax, zbrojMax, null)
        {
        }

        public override double Utok(Postava oponent)
        {
            if (Mec != null)
            {
                return Utok(oponent, Mec.PoskozeniMax);
            }
            else
            {
                return Utok(oponent, PoskozeniMax);
            }
        }

        public Hrdina Clone()
        {
            //Hrdina klon = new Hrdina(this.Jmeno, this.Zdravi, this.ZdraviMax, this.PoskozeniMax, ZbrojMax, this.Mec.Clone());
            Hrdina klon = this.MemberwiseClone() as Hrdina;
            klon.Mec = klon.Mec.Clone();
            return klon;
        }

        public override string ToString()
        {
            return $"{Jmeno}, zdravi: {Zdravi}, zdraviMax: {ZdraviMax}, poskozeniMax: {PoskozeniMax}, zbrojMax: {ZbrojMax}, mec: {Mec.PoskozeniMax}";
        }

    }
}
