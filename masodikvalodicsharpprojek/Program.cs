using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodikvalodicsharpprojek
{
    class Program
    {
        static void Main(string[] args)

        {
            /* Console.WriteLine("1-től 100-ig azoka a szamok, melyek valodi osztoinak az osszege oszthato hettel.");
             for (int i = 0; i <= 101; i++)
             {

                 if (osszegHettel(i))
                 {
                     Console.WriteLine($"{i} valódi osztóinak az összege osztható 7-tel.");
                 }

             }*/
            Console.WriteLine("2tol 100ig a prim szamok");


            for (int i = 2; i < 101; i++)
            {
                if (primszamE(i))
                {
                    Console.WriteLine(i);
                }

            }

            Console.ReadKey();
        }
        static bool osszegHettel(int szam)
        {
            int osszeg = 0;
            bool hettel = true;

            for (int i = 1; i < szam; i++)
            {
                if (szam % i == 0)
                {
                    osszeg += i;
                }
            }

                if (osszeg % 7 != 0)
            {
                hettel = false;
            }
            return hettel;
        }
        static bool primszamE(int szam)
        {
            bool primE = true;
            int hatar = (int)Math.Floor(Math.Sqrt(szam)) + 1;

            for (int i = 2; i < hatar; i++)
            {
                if (szam % i == 0)
                {
                    primE = false;
                    break;
                }
            }
            return primE;
        }
    }
}
