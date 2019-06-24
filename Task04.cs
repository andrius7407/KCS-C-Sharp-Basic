using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapas4
{
    class Program
    {
        static void Main(string[] args)
        {
            int praejoMinuciu = 0;
            int praejoSekundziu = 0;
            Console.WriteLine("įveskite valandas (0 - 24):");
            int valandos = Convert.ToInt32(Console.ReadLine());      
            if (valandos < 0 || valandos > 24)
            {
                while (valandos < 0 || valandos > 24)
                {
                    Console.WriteLine("neteisingas formatas, įveskite is naujo:");
                    valandos = Convert.ToInt32(Console.ReadLine());
                }                
            }
            if (valandos == 24)
            {
                praejoMinuciu = valandos * 60;
                praejoSekundziu = praejoMinuciu * 60;
                Console.WriteLine("Po vidurnakcio praejo " + praejoMinuciu + " minuciu ir " + praejoSekundziu + " sekundziu");
            }
            else
            {
                Console.WriteLine("įveskite minutes:");
                int minutes = Convert.ToInt32(Console.ReadLine());
                if (minutes < 0 && minutes > 59)
                {
                    while (minutes < 0 && minutes > 59)
                    {
                        Console.WriteLine("neteisingas formatas, įveskite is naujo:");
                        minutes = Convert.ToInt32(Console.ReadLine());
                    }
                }
                praejoMinuciu = valandos * 60 + minutes;
                praejoSekundziu = praejoMinuciu * 60;
                Console.WriteLine("Po vidurnakcio praejo " + praejoMinuciu + " minuciu ir " + praejoSekundziu + " sekundziu");
            }           
            Console.ReadKey();
        }
    }
}
