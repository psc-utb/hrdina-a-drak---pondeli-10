using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdina_a_drak___pondeli_10
{
    public class ArenaPostav
    {
        public Postava[] Postavy { get; set; }

        public ArenaPostav(/*params*/ Postava[] postavy)
        {
            Postavy = postavy;
        }


        public void Boj()
        {

            while (PostavyMohouBojovat())
            {
                for (int i = 0; i < Postavy.Length; ++i)
                {
                    if (Postavy[i].MuzeBojovat())
                    {
                        Postava oponent = Postavy[i].VyberOponenta(Postavy);
                        if (oponent != null)
                        {
                            if (Postavy[i] is Hrdina hrdina)
                            {
                                double utok = hrdina.Utok(oponent);
                                Console.WriteLine($"{Postavy[i].Jmeno} zaútočil hodnotou: {utok}. {oponent.Jmeno} má {oponent.Zdravi} životů.");
                            }
                            else
                            {
                                double utok = Postavy[i].Utok(oponent);
                                Console.WriteLine($"{Postavy[i].Jmeno} zaútočil hodnotou: {utok}. {oponent.Jmeno} má {oponent.Zdravi} životů.");
                            }
                        }
                    }
                }
                Console.WriteLine(String.Empty);
            }
        }

        public bool PostavyMohouBojovat()
        {
            int kolikMuzeBojovat = 0;
            foreach (var postava in Postavy)
            {
                if (postava.MuzeBojovat())
                {
                    ++kolikMuzeBojovat;
                }
            }

            if (kolikMuzeBojovat > 1)
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
