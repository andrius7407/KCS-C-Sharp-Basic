/* Jaunasis matematikas ir gobšus turtuolis Jaunasis matematikas, 
pastebėjęs gobšaus turtuolio bukumą, pasiūlė sandorį: 
Pirmą dieną jis turtuoliui duos 1 mln. dolerių, o tas jam 2 centus. 
Kitą dieną vėl duos 1 mln. dolerių, o tas jam dvigubai - 4 centus. 
Ir taip jie darys visą mėnesį - 31 dieną. Parašykite programą, kuri suskaičiuotų, 
kiek pinigų duos matematikas turtuoliui ir kiek turtuolis sumokės matematikui.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapas35
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumaDvigubai = Math.Pow(2, 31) / 100;
            double milijonai = 31 * 1000000;
            Console.WriteLine("matematikas gaus - " +sumaDvigubai+" turtuolis gaus - "+ milijonai);
            Console.ReadKey();
        }
    }
}
