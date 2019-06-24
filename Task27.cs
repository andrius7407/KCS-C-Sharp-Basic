/*
Japonų kalendorius. 
Senovės japonų kalendorių sudaro 60 metų ciklas. 
Visi metai cikle buvo sunumeruoti nuo 1 iki 60 ir suskirstyti poromis, 
kurių kiekviena turėjo savo spalvą (žalią, raudoną, geltoną, baltą ar juodą). 
Ciklo metų spalvos buvo paskirstytos taip: 1,2,11,12...51,52 metai - žalia spalva; 
3,4,13,14...53,54 - raudona; 5,6,15,16...55,56 - geltona; 7,8,17,18...57,58 - balta; 
9,10,19,20...59,60 - juoda; Žinoma, kad naujasis 60 metų ciklas prasidėjo 1984 ir baigsis 2043 metais; 
1984 ir 1985 buvo žalios spalvos metai, 1986 ir 1987 buvo raudonos spalvos metai, 2043 bus juodos spalvos. 
Parašykite programą, kuri nustatytų ir išspausdintų metų tarp 1800 ir 2200 spalvą.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27japonu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite metus - 1800-2200 imtinai");
            int metai = Convert.ToInt32(Console.ReadLine());
            int cikloMetai = Math.Abs(1744 - metai) % 60 + 1;
            if(cikloMetai % 10 == 1 || cikloMetai % 10 == 2)
            {
                Console.WriteLine("zalia spalva");
            }
            else if (cikloMetai % 10 == 3 || cikloMetai % 10 == 4)
            {
                Console.WriteLine("raudona spalva");
            }
            else if (cikloMetai % 10 == 5 || cikloMetai % 10 == 6)
            {
                Console.WriteLine("geltona spalva");
            }
            else if (cikloMetai % 10 == 7 || cikloMetai % 10 == 8)
            {
                Console.WriteLine("balta spalva");
            }
            else if (cikloMetai % 10 == 9 || cikloMetai % 10 == 0)
            {
                Console.WriteLine("juoda spalva");
            }
            Console.ReadKey();
        }
    }
}
