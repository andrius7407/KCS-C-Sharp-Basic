using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapas69
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = DrauguSkaiciausIvedimas();
            int b = KgBagazoKainosIvedimas();
            int bsvoris = SuskaiciuotiBendraBagazoSvori(n);
            int suma = SkaiciuotiBendraSumaUzBagaza(bsvoris, b);
            RezultatuIsvedimasIKonsole(bsvoris, suma);
        }
        static int DrauguSkaiciausIvedimas()
        {
            Console.WriteLine("ivesti draugu skaiciu");
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
        static int KgBagazoKainosIvedimas()
        {
            Console.WriteLine("ivesti 1 kg bagazo kaina");
            int b = Convert.ToInt32(Console.ReadLine());
            return b;
        }
        static int SuskaiciuotiBendraBagazoSvori(int n)
        {
            int bsvoris = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("ivesti {0} draugo kuprines svori", i + 1);
                int m = Convert.ToInt32(Console.ReadLine());
                bsvoris = bsvoris + m;
            }
            return bsvoris;

        }
        static int SkaiciuotiBendraSumaUzBagaza(int bsvoris, int b)
        {
            int suma = bsvoris * b;
            return suma;
        }
        static void RezultatuIsvedimasIKonsole(int bsvoris, int suma)
        {
            Console.WriteLine("draugai vezasi {0} kg bagazo, uz kuri sumokes {1}euru", bsvoris, suma);
            Console.ReadKey();
        }
    }
}
