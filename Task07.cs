using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapas7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesti staciakampio virsutinio kairiojo tasko koordinates ( ; )");
            string eiluteA = Console.ReadLine();
            string[] koordA = eiluteA.Split(';');
            double ax = Convert.ToDouble(koordA[0]);
            double ay = Convert.ToDouble(koordA[1]);
            Console.WriteLine("ivesti staciakampio apatinio desiniojo tasko koordinates ( ; )");
            string eiluteB = Console.ReadLine();
            string[] koordB = eiluteB.Split(';');
            double bx = Convert.ToDouble(koordB[0]);
            double by = Convert.ToDouble(koordB[1]);
            double plotas = (Math.Abs(ax - bx)) *(Math.Abs(ay - by));
            double perimetras = ((Math.Abs(ax - bx)) + (Math.Abs(ay - by))) * 2;
            Console.WriteLine("staciakampio plotas : {0}, perimetras : {1}", plotas, perimetras);
            Console.ReadKey();
            
        }
    }
}
