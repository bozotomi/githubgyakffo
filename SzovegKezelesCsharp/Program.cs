using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzovegKezelesCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*50.Feladat:
            Console.Write("Kérek egy szot");
            string szo = Console.ReadLine();

            for (int i = 0; i < szo.Length; i++)
            {
                Console.Write(szo[i] + " ");
            }
            Console.WriteLine('\b');

            Console.ReadKey(true);*/

            /*51.Feladat:
            Console.WriteLine("Kérek egy szot");
            string szo = Console.ReadLine();
            Console.WriteLine("Kérem a tabu karaktert");
            char tabu = Char.Parse(Console.ReadLine());

            for (int i = 0; i < szo.Length; i++)
            {
                if (szo[i] != tabu)
                {
                    Console.Write(szo[i]);
                }
            }

            Console.ReadKey(true);*/
            /*52.Feladat:
            Console.WriteLine("Kérek egy szot");
            string szo = Console.ReadLine();
            for (int i = 0; i < szo.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(szo[i]);
                }
            }
            Console.ReadKey(true);*/
            /*Plusz feladat:
            //adott indexű elem kiiratasa
            Console.WriteLine("Kérek egy szot");
            string szo = Console.ReadLine();
            Console.Write("Kérem az indexet:");
            int index = Int32.Parse(Console.ReadLine());

            if (index < szo.Length)
            {
                Console.WriteLine($"A kereesett karakter: {szo[index]}");
            }
            else
            {
                Console.WriteLine($"Ilyen indexű karakter nincsen mivel tul rovid a megadott szo (0 - {szo.Length - 1})");
            }
            Console.ReadKey(true);*/
            /*53.Feladat:
            Console.WriteLine("Kérem a szot");
            string szo = Console.ReadLine();

            int i = 0;

            while (i < szo.Length)
            {
                Console.WriteLine($"{szo[i]} - {(int)szo[i]}");
                i++;
            }
            Console.ReadKey(true);*/
            /*54.feladat:
            Console.WriteLine("Kérem a szot");
            string szo = Console.ReadLine();

            for (int i = szo.Length -1; i >= 0; i--)
            {
                Console.Write(szo[i]);
            }
            Console.ReadKey(true);*/
            /*55.feladat:
            Console.Write("Kérem egy mondatot");
            string mondat = Console.ReadLine();

            for (int i = 0; i < mondat.Length; i++)
            {
                if ((int)mondat[i] != 32)
                {
                    Console.Write(mondat[i]);
                }
                else
                {
                    Console.WriteLine();
                }
            }


            Console.ReadKey(true);*/
            /*55.feladat masodik megoldas:
            Console.Write("Kérem egy mondatot");
            string mondat = Console.ReadLine();
            string[] tomb = mondat.Split(' ');

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }

            Console.ReadKey(true);*/


            /*56.Feladat:
            Console.WriteLine("Kérek egy szot");
            string szo = Console.ReadLine();
            string forditottSzo = "";

            for (int i = szo.Length -1 ; i >= 0; i--)
            {
                forditottSzo += szo[i];
            }
            Console.WriteLine(forditottSzo.ToUpper());

            Console.ReadKey(true);*/


            /*57.Feladat:
            Console.Write("Kérem a mondatot! ");
            string mondat = Console.ReadLine();
            string[] tomb = mondat.Split(' ');
            for (int i = 0; i < tomb.Length; i++)
            {
                string elsobetu = tomb[i].Substring(0, 1).ToUpper();
                string maradek = tomb[i].Substring(1);
                Console.WriteLine(elsobetu + maradek);
            }
            

            Console.ReadKey(true);*/
            //plusz fealadat: minden masodik betu legyen nagy betuvel kiirva
            Console.WriteLine("Kérek egy szot");
            string szo = Console.ReadLine();

            for (int i = 0; i < szo.Length; i++)
            {
                if (i % 2 == 1)
                {
                    char ch = ((int)szo[i] - 32);
                }
            }



            Console.ReadKey(true);
        }
    }
}
