using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrdina_a_drak___pondeli_10
{
    public class Arena
    {
        public Hrdina Hrdina { get; set; }
        public Drak Drak { get; set; }

        public Arena(Hrdina hrdina, Drak drak)
        {
            Hrdina = hrdina;
            Drak = drak;
        }

        public void Boj()
        {

            while (Hrdina.JeZivy() && Drak.JeZivy())
            {
                double utok = Hrdina.Utok(Drak);
                Console.WriteLine($"Hrdina zaútočil hodnotou: {utok}. Drakovi zbývá {Drak.Zdravi} životů.");
                if (Drak.JeZivy())
                {
                    utok = Drak.Utok(Hrdina);
                    Console.WriteLine($"Drak zaútočil hodnotou: {utok}. Hrdinovi zbývá {Hrdina.Zdravi} životů.");
                }
                Console.WriteLine(String.Empty);
            }

        }

    }
}
