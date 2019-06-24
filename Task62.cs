/*
Palūkanos Bankas moka 4% metinių palūkanų. Indėlininkas pasidėjo į banką 100 Lt. 
Sudarykite kasmetinę banko ataskaitą iki n metų.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapas62
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("indelio ataskaita po n metu. ivesti n");
            double n = Convert.ToDouble(Console.ReadLine());
            double suma = 100;
            for (double i = 1; i <= n; i++)
            {
                suma = suma * 1.04;
            }
            Console.WriteLine("indelis po {0} metu bus {1:0.00} litu", n, suma);
            Console.ReadKey();
        }
    }
}
