﻿using System;
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
            Bedna bedna = new Bedna(50, 2);
            while (PostavyMohouBojovat())
            {
                for (int i = 0; i < Postavy.Length; ++i)
                {
                    if (Postavy[i].MuzeBojovat())
                    {
                        Postava oponent = Postavy[i].VyberOponenta(Postavy);
                        if (oponent != null)
                        {
                            double utok = Postavy[i].Utok(oponent);
                            Console.WriteLine($"{Postavy[i].Jmeno} zaútočil hodnotou: {utok}. {oponent.Jmeno} má {oponent.Zdravi} životů.");
                        }

                        if (bedna.JeRozbita() == false)
                        {
                            double utok = Postavy[i].Utok(bedna);
                            Console.WriteLine($"{Postavy[i].Jmeno} rozbíjí bednu hodnotou: {utok}. Bedna má {bedna.Zdravi} životů.");
                            if (bedna.JeRozbita())
                            { 
                                Postavy[i].Zdravi += 0.2 * Postavy[i].ZdraviMax;
                                Console.WriteLine($"{Postavy[i].Jmeno} si z bedny zvýšil zdraví");
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
                if (postava.MuzeBojovat() && postava.MuzeVybratOponenta(Postavy))
                {
                    ++kolikMuzeBojovat;
                }
            }

            if (kolikMuzeBojovat > 0)
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
