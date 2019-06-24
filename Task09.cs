using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapas9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesti valandas, minutes, sekundes (00:00:00)");
            string eilute = Console.ReadLine();
            string[] duom = eilute.Split(':');
            int val = Convert.ToInt32(duom[0]);
            int min = Convert.ToInt32(duom[1]);
            int sek = Convert.ToInt32(duom[2]);
            int visoSekundziu = (val * 60 + min) * 60 + sek + 1;
            int sekundziuParoj = 24 * 60 * 60;

            if (visoSekundziu > sekundziuParoj)
            {
                visoSekundziu = visoSekundziu - sekundziuParoj;
            }
            int val1 = visoSekundziu / 60 / 60;
            int min1 = (visoSekundziu - (val1 * 60 * 60)) / 60;
            int sek1 = (visoSekundziu - (val1 * 60 * 60)) % 60 ;
            Console.WriteLine("{0:00}:{1:00}:{2:00}", val1, min1, sek1);
            Console.ReadKey();
        }
    }
}
