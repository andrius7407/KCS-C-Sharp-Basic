using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapas23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite metus");
            int metai = Convert.ToInt32(Console.ReadLine());
            if (metai % 4 == 0)
            {
                int numeris = (metai - 1896) / 4;
                Console.WriteLine("olimpiniu zaidyniu numeris - {0}", ++numeris);
            }
            else
            {
                Console.WriteLine("neolimpiniai metai");
            }
            Console.ReadKey();
        }
    }
}
