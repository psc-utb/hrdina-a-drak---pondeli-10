using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdina_a_drak___pondeli_10
{
    public abstract class Postava : IComparable<Postava>
    {

        public string Jmeno { get; set; }
        public double Zdravi { get; set; }
        public double ZdraviMax { get; set; }
        public double PoskozeniMax { get; set; }
        public double ZbrojMax { get; set; }
        public bool Utekl { get; set; }


        public Postava(string jmeno, double zdravi, double zdraviMax, double poskozeniMax, double zbrojMax)
        {
            Jmeno = jmeno;
            Zdravi = zdravi;
            ZdraviMax = zdraviMax;
            PoskozeniMax = poskozeniMax;
            ZbrojMax = zbrojMax;
            Utekl = false;
        }

        /// <summary>
        /// utok postavy
        /// </summary>
        /// <param name="oponent">oponent na ktereho postava utoci</param>
        /// <returns>vraci hodnotu utoku</returns>
        /// <exception cref="Exception">vyvolá se kdyz postava nemuze bojovat</exception>
        public virtual double Utok(Postava oponent)
        {
            return Utok(oponent, PoskozeniMax);
        }

        protected double Utok(Postava oponent, double poskozeniMax)
        {
            if (MuzeBojovat())
            {
                double hodnotaUtoku = 0;

                Random rnd = new Random();
                hodnotaUtoku = rnd.NextDouble() * poskozeniMax;
                hodnotaUtoku -= oponent.Obrana();
                if (hodnotaUtoku < 0)
                    hodnotaUtoku = 0;

                oponent.Zdravi -= hodnotaUtoku;

                return hodnotaUtoku;
            }
            else
                throw new Exception($"Postava se jménem \"{Jmeno}\" už nemůže bojovat!");
        }

        public virtual double Obrana()
        {
            double hodnotaObrany = 0;

            //dodelat obranu

            return hodnotaObrany;
        }

        public virtual Postava VyberOponenta(Postava[] postavy)
        {
            foreach(var postava in postavy)
            {
                if (postava.MuzeBojovat() && postava != this && KontrolaOponenta(postava))
                {
                    return postava;
                }
            }

            return null;
        }

        public bool MuzeVybratOponenta(Postava[] postavy)
        {
            Postava oponent = VyberOponenta(postavy);
            if (oponent != null)
                return true;
            else
                return false;
        }

        protected abstract bool KontrolaOponenta(Postava oponent);

        public bool MuzeBojovat()
        {
            return JeZivy() && Utekl == false;
        }
        public bool JeZivy()
        {
            if (Zdravi > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Jmeno}, zdravi: {Zdravi}, zdraviMax: {ZdraviMax}, poskozeniMax: {PoskozeniMax}, zbrojMax: {ZbrojMax}, hodnoceni postavy: {HodnoceniPostavy()}";
        }

        public int CompareTo(Postava other)
        {
            if (other == null)
                return 1;

            return this.HodnoceniPostavy().CompareTo(other.HodnoceniPostavy());
        }

        public virtual double HodnoceniPostavy()
        {
            return 0.3 * Zdravi + 0.4 * PoskozeniMax + 0.3 * ZbrojMax;
        }
    }
}
