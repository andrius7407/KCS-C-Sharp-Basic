using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapas12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pradejo spresti val:");
            int val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("pradejo spresti min:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("baige spresti val:");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("baige spresti min:");
            int min1 = Convert.ToInt32(Console.ReadLine());
            int pradSpresti = val * 60 + min;
            int baigSpresti = val1 * 60 + min1;
            if (pradSpresti > baigSpresti)
            {
                baigSpresti += 24 * 60;
            }
            int sprende = baigSpresti - pradSpresti;
            int val2 = sprende / 60;
            int min2 = sprende % 60;
            Console.WriteLine("uzdavinius mokinys sprende {0} valandu ir {1} minuciu", val2, min2);
            Console.ReadKey();
        }
    }
}
