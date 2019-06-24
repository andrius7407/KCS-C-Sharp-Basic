using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lapas19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesti keturzenkli skaiciu");
            int sk = Convert.ToInt32(Console.ReadLine());
            if (sk <= 999 || sk > 9999)
            {
                Console.WriteLine("skaicius ne keturzenklis");
            }
            else
            {
                int ketvirtas = sk % 10;
                sk = (sk - ketvirtas) / 10;
                int trecias = sk % 10;
                sk = (sk - trecias) / 10;
                int antras = sk % 10;
                sk = (sk - antras) / 10;
                int pirmas = sk % 10;
                int rez = ketvirtas * 1000 + trecias * 100 + antras * 10 + pirmas;
                Console.WriteLine("{0}", rez);
            }
            Console.ReadKey();
        }
    }
}
