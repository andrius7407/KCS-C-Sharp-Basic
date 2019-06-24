using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapas67
{
    class Program
    {
        static void Main(string[] args)
        {
            SpausdintiPradiniPranesima();
            int vaisiai = NuskaitytiVartotojoIvesti();
            NustatytiIrPranestiKuriemsSeimosNariamsPatiksPyragas(vaisiai);
            Console.ReadKey();
        }

        static int NuskaitytiVartotojoIvesti()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static void SpausdintiPradiniPranesima()
        {
            Console.WriteLine(
                "iveskite 1, jei pyragas su obuoliais, 2 - " +
                "jei melynem, 3 - jei serbentais, 4 - jei slyvom"
                );
        }

        static void NustatytiIrPranestiKuriemsSeimosNariamsPatiksPyragas(int x)
        {
            switch (x)
            {
                case 1:
                    Console.WriteLine("pyragas patiks mamai ir dukrai");
                    break;
                case 2:
                    Console.WriteLine("pyragas patiks mamai ir dukrai");
                    break;
                case 3:
                    Console.WriteLine("pyragas patiks teciui ir sunui");
                    break;
                case 4:
                    Console.WriteLine("pyragas patiks teciui ir sunui");
                    break;
            }
        }
    }
}
