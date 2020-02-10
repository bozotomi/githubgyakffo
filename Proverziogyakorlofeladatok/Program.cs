using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proverziogyakorlofeladatok
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Feladat:
            Console.WriteLine("Kérem a tomb elemszamat");
            int elemszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[elemszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kerem az {i + 1}. szamot: ");
                tomb[i] = Int32.Parse(Console.ReadLine());
                  
            }
            int maxKulombseg = Int32.MinValue;

            for (int i = 0; i < tomb.Length - 1; i++)
            {
                int kulombseg = Math.Abs(tomb[i] - tomb[i + 1]);
                if (maxKulombseg <= kulombseg)
                {
                    maxKulombseg = kulombseg;
                }
            }
            Console.WriteLine($"A maximalis kulombseg: {maxKulombseg}");

            Console.ReadKey(true);*/
            Console.WriteLine("Kérem a tomb elemszamat");
            int elemszam = Int32.Parse(Console.ReadLine());

            int[] tomb = new int[elemszam];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write($"Kerem az {i + 1}. szamot: ");
                tomb[i] = Int32.Parse(Console.ReadLine());

            }
            int elso = 0;
            int masodik = 0;
            int minKulombseg = Int32.MaxValue;

            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = i + 1; j < tomb.Length; j++)
                {
                      
                }
            }



            Console.ReadKey(true);
        }
    }
}
