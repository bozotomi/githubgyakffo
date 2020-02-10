using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mivel számoljak(kör, negyzet, teglalap, derekszoguharomszog)");
            string bemenet = Console.ReadLine();

            if (bemenet == "kör")
            {
                Console.Clear();
                Console.WriteLine("Kérek egy sugarat");
                double sugar = Int32.Parse(Console.ReadLine());
                Console.WriteLine("A sugár :" + sugar);
                double kerulet = sugar * sugar * Math.PI;
                Console.WriteLine("A kör kerulete: " + kerulet);
                double terulet = 2 * sugar * Math.PI;
                Console.WriteLine("A kör terulete: " + terulet);
            }
            else if (bemenet == "negyzet")
            {

                Console.Clear();
                Console.WriteLine("Kérem az oldalt(a)");
                double a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Az oldal(a) " + a);
                double kerulet = 4 * a;
                Console.WriteLine("A negyzet kerulete: " + kerulet);
                double terulet = a * a;
                Console.WriteLine("A negyzet terulete: " + terulet);
            }
            else if (bemenet == "teglalap")
            {
                Console.Clear();
                Console.WriteLine("Kérem a két oldalt(a, b)");
                double a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Az a oldal: "+ a);
                double b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("A b oldal: "+ b);
                double kerulet = 2 * a + 2 * b;
                Console.WriteLine("A tegalap kerulete: " + kerulet);
                double terulet = a * b;
                Console.WriteLine("A teglalap terulete: " + terulet);
            }
            else if (bemenet == "derekszoguharomszog")
            {
                Console.Clear();
                Console.WriteLine("Kérem a két befogot(a, b)");
                double a = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Az a oldal: " + a);
                double b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("A b oldal: " + b);
                double cnegyzet = (a * a) + (b * b);
                double c = Math.Sqrt(cnegyzet);
                double kerulet = a + b + c;
                Console.WriteLine("A derekszogu haromszog kerulete: " + kerulet);
                double terulet = a * b / 2;
                Console.WriteLine("A derekszogu haromszok terulete: " + terulet);

            }
            else
            {
                Console.WriteLine("A bekérhető geometriai alakzatok közöl várasszon legközelebb kérem");
            }
           

            Console.ReadKey(true);
        }
    }
}
