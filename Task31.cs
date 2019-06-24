using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapas31
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int sugalvotas = 0;
            for (int i = 0; i < 99 - 10; i++)
            {
                if ((x % 10) * 10 + x / 10 - 36 == x && (x / 10) * 2 == x % 10)
                {
                    sugalvotas = x;
                }
                x++;
            }
            Console.WriteLine(sugalvotas);
            Console.ReadKey();
        }
    }
}
