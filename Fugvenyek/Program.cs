using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fugvenyek
{
    class Program
    {
        static void Main(string[] args)
        {
            /*3.Feladat: //nem biztos hogy jó
            Console.Write("Kérem egy pozitív egész számot ide:");
            int szam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"A(z) {szam} prím tényezői: {kettososzto(szam)}");*/

            /*4.Feladat:
            Console.Write("Kérem egy pozitív egész számot ide:");
            int szam = Convert.ToInt32(Console.ReadLine());
            int[] tomb = osztokSzama(szam);
            Console.WriteLine($"A(z) {szam} tartalmaz:");
            Console.WriteLine($"{tomb[0]} 200-as érmét");
            Console.WriteLine($"{tomb[1]} 100-as érmét");
            Console.WriteLine($"{tomb[2]} 50-es érmét");
            Console.WriteLine($"{tomb[3]} 20-as érmét");
            Console.WriteLine($"{tomb[4]} 10-es érmét");
            Console.WriteLine($"{tomb[5]} 5-es érmét");
            Console.WriteLine($"{tomb[6]} 2-es érmét");
            Console.WriteLine($"{tomb[7]} 1-es érmét");

            Console.ReadLine();
        }
        /*static int kettososzto(int szam) //3-as hoz tartozo
        {
            int osztokszama = 0;
            while (szam % 2 == 0)
            {
                osztokszama++;
                szam /= 2; //szam=szam/2;
            }
            return osztokszama;
        }*/

            /*static int[] osztokSzama(int szam)
            {
                int[] ermekSzama = new int[8];
                int[] oszto = new int[] { 200, 100, 50, 20, 10, 5, 2, 1 };
                for (int i = 0; i < oszto.Length; i++)
                {
                    while (szam >= oszto[i])
                    {
                        ermekSzama[i]++;
                        szam -= oszto[i]; //szam=szam/oszto;
                    }
                }
                return ermekSzama;*/
            /*4.Feladat:
        Console.Write("Kérem egy pozitív egész számot ide:");
        int szam = Convert.ToInt32(Console.ReadLine());
        int[] tomb = osztokSzama(szam);
        Console.WriteLine($"A(z) {szam} tartalmaz:");
        Console.WriteLine($"{tomb[0]} 200-as érmét");
        Console.WriteLine($"{tomb[1]} 100-as érmét");
        Console.WriteLine($"{tomb[2]} 50-es érmét");
        Console.WriteLine($"{tomb[3]} 20-as érmét");
        Console.WriteLine($"{tomb[4]} 10-es érmét");
        Console.WriteLine($"{tomb[5]} 5-es érmét");
        Console.WriteLine($"{tomb[6]} 2-es érmét");
        Console.WriteLine($"{tomb[7]} 1-es érmét");

        Console.ReadLine();
    }

    static int[] osztokSzama(int szam)
    {
        int meddig = (int)Math.Floor(Math.Log(szam) / Math.Log(2));
        int[] kettesOsztok = new int[8];
        int[] oszto = new int[meddig];

        for (int i = 0; i < kettesOsztok.Length; i++)
        {
            kettesOsztok[i] = (int)Math.Pow(2, i);
        }

        for (int i = 0; i < kettesOsztok.Length; i++)
        {
            while (szam >= oszto[i])
            {
                kettesOsztok[i]++;
                szam -= oszto[i]; // szam = szam - oszto[i];
            }
        }
        return kettesOsztok;*/
            //6.Feladat:
            Console.Write("Kérem egy pozitív egész számot ide:");
            int szam = Convert.ToInt32(Console.ReadLine());
            int[] tomb = kettesSzamrendszer(szam);

            string kiir = 
            

            Console.ReadLine();
        }

        static int[] osztokSzama(int szam)
        {
            int meddig = (int)Math.Floor(Math.Log(szam) / Math.Log(2));
            int[] kettesOsztok = new int[8];
            int[] oszto = new int[meddig];

            for (int i = 0; i < kettesOsztok.Length; i++)
            {
                kettesOsztok[i] = (int)Math.Pow(2, i);
            }

            for (int i = 0; i < kettesOsztok.Length; i++)
            {
                while (szam >= oszto[i])
                {
                    kettesOsztok[i]++;
                    szam -= oszto[i]; // szam = szam - oszto[i];
                }
            }
            return kettesOsztok;

        }
    }
}

