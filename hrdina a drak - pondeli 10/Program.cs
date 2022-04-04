using System;
using System.Collections.Generic;
using System.Linq;

namespace hrdina_a_drak___pondeli_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Mec mec = new Mec(25);
            Hrdina hrdina = new Hrdina("Geralt", 100, 100, 10, 10, mec);
            Hrdina hrdina2 = new Hrdina("Dovahkiin", 100, 100, 10, 10, mec);
            Drak drak = new Drak("Alduin", 100, 100, 11, 10);
            Drak drak2 = new Drak("Šmak", 100, 100, 11, 10);
            Vlk vlk = new Vlk("Wolf", 50, 50, 5, 5);
            Vlk vlk2 = new Vlk("Wolf2", 50, 50, 5, 5);
            Vlk vlk3 = new Vlk("Wolf3", 50, 50, 5, 5);
            Vlk vlk4 = new Vlk("Wolf4", 50, 50, 5, 5);


            //klonovni a zmena hrdiny
            /*Hrdina hrdinaKlon = hrdina.Clone();
            hrdinaKlon.Jmeno += " klon";
            hrdinaKlon.ZdraviMax = 150;
            hrdinaKlon.ZbrojMax = 15;
            hrdinaKlon.Mec.PoskozeniMax = 20;

            Console.WriteLine(hrdina.ToString());
            Console.WriteLine(hrdinaKlon.ToString());
            Console.WriteLine(String.Empty);*/


            //Arena arena = new Arena(hrdina, drak);
            //arena.Boj();

            //funguje jen s params v konstruktoru
            //ArenaPostav arenaPostav = new ArenaPostav(hrdina, drak);

            List<Postava> postavy = new List<Postava>() { hrdina, drak2, drak, vlk3, vlk4, /*, hrdinaKlon*/ vlk, hrdina2, vlk2 };

            //Array.Sort(postavy);
            postavy.Sort();
            foreach (var postava in postavy)
            {
                Console.WriteLine(postava.ToString());
            }
            Console.WriteLine(String.Empty);
            
            postavy.Add(new Hrdina("hrdina 5", 20, 5, 5));
            postavy.RemoveAt(2);
            ArenaPostav arenaPostav = new ArenaPostav(postavy);
            arenaPostav.Boj();

            foreach(var postava in arenaPostav.Postavy)
            {
                Console.WriteLine(postava.ToString());
            }

        }
    }
}
