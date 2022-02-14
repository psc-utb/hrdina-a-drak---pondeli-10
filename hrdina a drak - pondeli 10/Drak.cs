using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdina_a_drak___pondeli_10
{
    public class Drak
    {
        public string Jmeno { get; set; }
        public double Zdravi { get; set; }
        public double ZdraviMax { get; set; }
        public double PoskozeniMax { get; set; }
        public double ZbrojMax { get; set; }
        public bool Utekl { get; set; }

        public Drak(string jmeno, double zdravi, double zdraviMax, double poskozeniMax, double zbrojMax)
        {
            Jmeno = jmeno;
            Zdravi = zdravi;
            ZdraviMax = zdraviMax;
            PoskozeniMax = poskozeniMax;
            ZbrojMax = zbrojMax;
            Utekl = false;
        }

        /// <summary>
        /// utok draka
        /// </summary>
        /// <param name="oponent">hrdina na ktereho drak utoci</param>
        /// <returns>vraci hodnotu utoku</returns>
        /// <exception cref="Exception">vyvolá se kdyz drak nemuze bojovat</exception>
        public double Utok(Hrdina oponent)
        {
            if (MuzeBojovat())
            {
                double hodnotaUtoku = 0;

                Random rnd = new Random();
                hodnotaUtoku = rnd.NextDouble() * PoskozeniMax;
                hodnotaUtoku -= oponent.Obrana();
                if (hodnotaUtoku < 0)
                    hodnotaUtoku = 0;

                oponent.Zdravi -= hodnotaUtoku;

                return hodnotaUtoku;
            }
            else
                throw new Exception("Drak už nemůže bojovat!");
        }

        public double Obrana()
        {
            double hodnotaObrany = 0;

            //dodelat obranu

            return hodnotaObrany;
        }

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
    }
}
