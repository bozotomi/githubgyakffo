using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tombokcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*42-43.Feladatok:
            Console.WriteLine("Mennyi adattal dolgozzak:");
            int darabszam = Int32.Parse(Console.ReadLine());
            
            //Letre hozzuk a tombot
            int[] tomb = new int[darabszam];

            //Feltoltjuk a tombot egesz szamokkal
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) ({i + 1}). számot");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            //Megszamoljuk a paratlan tombelemeket
            int paratlanokSzama = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 1)
                {
                    paratlanokSzama++;
                }
            }
            Console.WriteLine($"A tombben talalhato paratlan szamok szama: {paratlanokSzama}");

            //Páros szamok összege
            int parosszamokOsszege = 0;                //Az elozo for ciklusba egy else aggal be lehet helyezni az osszget es igy egy for cikluson belul lesznek
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    parosszamokOsszege += tomb[i];
                }
            }

            Console.WriteLine($"A paros szamok oszzege: {parosszamokOsszege}");
            Console.ReadKey(true);*/

            /*44.Feladat:
            Console.WriteLine("Mennyi adattal dolgozzak:");
            int darabszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[darabszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) ({i + 1}). számot");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }
            int parosSzamok = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 2 == 0)
                {
                    parosSzamok += tomb[i];
                    Console.WriteLine($" {i + 1}. a {parosSzamok} sorszama");
                }
            }


            Console.ReadKey(true);*/
            /*45.Feladat:
            Console.WriteLine("Mennyi adattal dolgozzak:");
            int darabszam = Int32.Parse(Console.ReadLine());

           
            int[] tomb = new int[darabszam];

            
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) ({i + 1}). számot");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }
            Console.Write("Kérem a probaszamot");
            int probaSzam = Convert.ToInt32(Console.ReadLine());
            int tombIndex = -1;
            bool vanE = false;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaSzam)
                {
                    tombIndex = i + 1;
                    vanE = true;
                    break;
                }
            }
            if (vanE)
            {
                Console.WriteLine($"Talaltam ilyen szamot a(z) {tombIndex}. pozicioban");
            }
            else
            {
                Console.WriteLine("Nincs ilyen szam a tombben");
            }

            Console.ReadKey(true);*/
            /*46.Feladat:
            Console.WriteLine("Mennyi adattal dolgozzak:");
            int darabszam = Int32.Parse(Console.ReadLine());


            int[] tomb = new int[darabszam];


            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) ({i + 1}). számot");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }
            Console.Write("Kérem a probaszamot");
            int probaSzam = Convert.ToInt32(Console.ReadLine());
            int szamlalo = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaSzam)
                {

                    szamlalo++;
                }
            }
            if (szamlalo != 0)
            {
                Console.WriteLine($" A(z) {probaSzam} ennyiszer szerepel {szamlalo}");
            }
            else
            {
                Console.WriteLine("Ilyen szam nem szerepel a tombben");
            }
            Console.ReadKey(true);*/
            /*47.Feladat:
            Console.WriteLine("Mennyi adattal dolgozzak:");
            int darabszam = Int32.Parse(Console.ReadLine());


            string[] tomb = new string[darabszam];


            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) ({i + 1}). nevet");
                string keresztnev = Console.ReadLine();
                tomb[i] = keresztnev;
            }
            Console.Write("Kérem a probanevet");
            string probaNev = Console.ReadLine();
            int szamlalo = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == probaNev)
                {

                    szamlalo++;
                }
            }
            if (szamlalo != 0)
            {
                Console.WriteLine($" A(z) {probaNev} ennyiszer szerepel {szamlalo}");
            }
            else
            {
                Console.WriteLine("Ilyen nev nem szerepel a tombben");
            }
            Console.ReadKey(true);*/

            //48.Feladat:
            Console.WriteLine("Mennyi adattal dolgozzak:");
            int darabszam = Int32.Parse(Console.ReadLine());

            
            int[] tomb = new int[darabszam];

            
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kérem a(z) ({i + 1}). számot");
                int szam = Int32.Parse(Console.ReadLine());
                tomb[i] = szam;
            }

            int maxKulombseg = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < tomb.Length; j++)
                {
                    int kulombseg = tomb[i] - tomb[j];
                    if (maxKulombseg <= kulombseg)
                    {
                        maxKulombseg = kulombseg;
                    }
                }

            }
            Console.WriteLine("A Kulombeseg: " + maxKulombseg);

            //tombKiir(tomb);
            Array.Sort(tomb);
            //tombKiir(tomb);

            Console.WriteLine($"A kulombseg: {tomb[tomb.Length - 1] - tomb[0]}");
            Console.WriteLine($"A kulombseg: {tomb.Max() - tomb.Min()}");

            Console.ReadKey(true);
        }
        static void tombKiir(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(tomb[i]);
            }
        }
    }
}
