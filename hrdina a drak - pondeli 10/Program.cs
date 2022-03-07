using System;

namespace hrdina_a_drak___pondeli_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Mec mec = new Mec(15);
            Hrdina hrdina = new Hrdina("Geralt", 100, 100, 10, 10, mec);
            Drak drak = new Drak("Alduin", 100, 100, 11, 10);
            //Vlk vlk = new Vlk("Wolf", 50, 50, 5, 5);


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

            Postava[] postavy = new Postava[] { hrdina, drak/*, hrdinaKlon*/ /*, vlk*/ };
            ArenaPostav arenaPostav = new ArenaPostav(postavy);
            arenaPostav.Boj();

        }
    }
}
