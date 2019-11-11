using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoValodiCharpProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Feladat: 
            string kiir = "Hello world!";
            Console.WriteLine(kiir);*/

            /* 2. Feladat:
            Console.Write("Add meg a neved: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"Üdvözöllek {nev}!");*/

            /* 3. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szam = Int32.Parse(Console.ReadLine());
            int szam = Convert.ToInt32(Console.ReadLine());
            double szam = Double.Parse(Console.ReadLine());
            double szam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"A szám: {szam} kétszerese: {2 * szam}");*/

            /* 4. feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            int osszeg = szamA + szamB;
            int kulonbseg = szamA - szamB;
            int szorzat = szamA * szamA;
            double hanyados = (double)szamA / szamB;

            Console.WriteLine($"A két szám: {szamA} és {szamB}: ");
            Console.WriteLine($"Összege: {osszeg}");
            Console.WriteLine($"Különbsége: {kulonbseg}");
            Console.WriteLine($"Szorzata: {szorzat}");
            Console.WriteLine($"Hányadosa: {hanyados}");*/

            /* 5. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA > szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else if (szamB > szamA)
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }
            else
            {
                Console.WriteLine("A két szám egyenlő!");
            }

            if (szamA >= szamB)
            {
                Console.WriteLine($"A nagyobbik szám: {szamA}");
            }
            else
            {
                Console.WriteLine($"A nagyobbik szám: {szamB}");
            }*/

            /* 6. Feladat: 
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA <= szamB)
            {
                if (szamA <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamA}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }
            else
            {
                if (szamB <= szamC)
                {
                    Console.WriteLine($"A legkisebb szám: {szamB}");
                }
                else
                {
                    Console.WriteLine($"A legkisebb szám: {szamC}");
                }
            }*/

            /* 7. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());
            Console.Write("Adj meg egy harmadik számot: ");
            int szamC = Convert.ToInt32(Console.ReadLine());

            if (szamA + szamB > szamC && szamA + szamC > szamB && szamB + szamC > szamA)
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög szerkeszthető.");
            }
            else
            {
                Console.WriteLine($"A három számból: {szamA}, {szamB} és {szamC} háromszög nem szerkeszthető.");
            }*/

            /* 8. Feladat:
            Console.Write("Adj meg egy számot: ");
            int szamA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Adj meg egy másik számot: ");
            int szamB = Int32.Parse(Console.ReadLine());

            if (szamA >= 0 && szamB >= 0)
            {
                double szamtani = ((double)szamA + szamB) / 2;
                double mertani = Math.Sqrt(szamA * szamB);
                Console.WriteLine($"A két szám: {szamA} és {szamB} számtani közepe: {szamtani}");
                Console.WriteLine($"A két szám: {szamA} és {szamB} mértani közepe: {mertani}");
            }
            else
            {
                Console.WriteLine("A feladat nem megoldható!");
            }*/
            /* 15.Feladat:*//*elso megoldas*/

            /* 
             /*16. Feladat:
            Console.WriteLine("Kérem a pozitív egész szám");
            int bemenet = Convert.ToInt32(Console.ReadLine());
            string kimenet = "";
            for (int i = 1; i <= bemenet; i++)
            {
                kimenet += i + "\n";
            }
            Console.WriteLine(kimenet);
             /*   while (i < bemenoSzam)
            {
                Console.Write(i + " ");
                i = i + 1;
            }
            /*masodig megoldas
             string kiiratas = "";

            /* for (int i = 1; i <= bemenoSzam; i++)
             {
                 if (i == bemenoSzam)
                 {
                     kiiratas += i + "";
                     Console.Write($"{i}");
                 }
                 else
                 {
                     if (i != 0)
                     {
                         Console.Write($"{i}, ");
                     }
                 }

             }*/
            /* 17.Feladat:
            Console.Write("Kérem a pozitív egész szám");
            int bemenoSzam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A szám egész osztói");

            for (int i = 1; i <= bemenoSzam; i++)
            {
                if (bemenoSzam%i == 0)
                {
                    
                    Console.Write(i + "," );
                }
                

            }*/
            /*18.Feladat:
            Console.Write("Kérem a pozitív egész szám");
            int bemenoSzam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A szám egész osztói");

            for (int i = 1; i <= bemenoSzam; i++)
            {
                if (bemenoSzam % i == 0)
                {

                    Console.Write(i + ",");
                }


            }*/
            /*plusz feladat: prymszám keresése
            Console.Write("Kérem a pozitív egész szám");
            int bemenoSzam = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ez egy prímszám");
            int szamlalo = 0;
            for (int i = 1; i <= bemenoSzam + 1; i++)
            {
                if (bemenoSzam % i == 0)
                {
                    szamlalo++;
                    
                }
               

            }
            if (szamlalo == 2)
            {
                Console.WriteLine($"A bemenő szám {bemenoSzam} prím");
            }
            else
            {
                Console.WriteLine($"A bemenő szám {bemenoSzam} nem prím");
            }*/
            /*18.Feladat
            Console.Write("Kérem a pozitív egész szám");
            int bemenoSzam = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ez egy prímszám");
            int szamlalo = 0;
            int osztokOsszege = 0;
            for (int i = 1; i <= bemenoSzam + 1; i++)
            {
                if (bemenoSzam % i == 0)
                {
                    szamlalo++;
                    osztokOsszege += i;

                }


            }
            if (szamlalo == 2)
            {
                Console.WriteLine($"A bemenő szám {bemenoSzam} prím");
                Console.WriteLine($"A bemenő szám {bemenoSzam} osztóinak összege: {osztokOsszege}");
            }
            else
            {
                Console.WriteLine($"A bemenő szám {bemenoSzam} nem prím");
                Console.WriteLine($"A bemenő szám {bemenoSzam} osztóinak összege{osztokOsszege}");
            }
           /* 19.Feladat:
            Console.Write("Kérem a pozitív egész szám");
            int bemenoSzam = Int32.Parse(Console.ReadLine());
          
            int i = 1;
            int osztokOsszege = 0;

            while (i <= bemenoSzam)
            {
                if (bemenoSzam % i == 0)
                {
                    osztokOsszege += i;
                }
                i++;
            }
            if (osztokOsszege == 2 * bemenoSzam)

            {
                Console.WriteLine($"A szám {bemenoSzam} tökéletes szám");
            }
            else
            {
                Console.WriteLine($"A szám {bemenoSzam} nem tökéletes szám");
            }
            */
            /*20.Feladat:
            int alap = -1;
            while (alap <= 0 || alap > 10)
            {
                Console.Write("Kérem az alapot: ");
                alap = Int32.Parse(Console.ReadLine());
            }
            int kitevo = -1;
            while (kitevo < 0 || kitevo > 10)
            {
                Console.Write("Kérem a kitevőt: ");
                kitevo = Int32.Parse(Console.ReadLine());
            }
            
           
            int hatvany = 1;

            for (int i = 0; i < kitevo; i++)
            {
                hatvany *= alap;
            }
            Console.Write($"A hatvány: {hatvany}");*/
            /*21.Feladat:
            int szam = 1;
            while (szam%2 == 1 || szam%2 == -1)
            {
                Console.Write("Kérem a pozitív egész számot: ");
                szam = Int32.Parse(Console.ReadLine());
            }*/
            /*Plusz felaadat prim szmara lepjen ki a ciklusbol
            int szam = 3;

            while (PrimszamE(szam))
            {
                Console.Write("Kérek egy nem prím számot: ");
                szam = Convert.ToInt32(Console.ReadLine());
            }

            Console.ReadKey(true);
        }
        static bool PrimszamE(int szam)
        {
            bool teljesul = true;

            int osztokSzama = 0;

            for (int i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    osztokSzama++;
                }
            }
            if (osztokSzama== 2)
            {
                return teljesul;
            }
            else
            {
                return !teljesul;
            }*/
            /*22.feladat:*/
            int szam = 0;

            int osszeg = 0;

            while (szam <= 10)
            {
                
                Console.WriteLine("Kérek egy 10nél kisebb számot: ");
                szam = Int32.Parse(Console.ReadLine());
               
                if (szam <= 10)
                {
                    osszeg += szam;
                    Console.WriteLine($"Az eddig beolvasott jó számok összege: {osszeg}.");
                }
                else
                {
                    Console.WriteLine("Nem teljesül");
                    break;
                }
            }

            Console.WriteLine($"Az addig beolvasott számok összege: {osszeg}.");
            Console.ReadKey(true);
        }
    }
}




    
