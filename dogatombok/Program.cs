
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            Console.Write("Hány szavas legyen a mondat? ");
            int hossz = int.Parse(Console.ReadLine());
            string[] mondat = new string[hossz];

            for (int i = 0; i < hossz; i++)
            {
                Console.Clear();
                int temphossz = r.Next(1, 12);
                string tempszo = "";
                while (tempszo.Length != temphossz)
                {
                    Console.Write($"Adj meg egy {temphossz} hosszúságú szót: ");
                    tempszo = Console.ReadLine();
                }
                mondat[i] = Convert.ToString(tempszo);
            }

            Console.WriteLine("\nA teljes mondat:");
            for (int i = 0; i < mondat.Length; i++)
            {
                if (i == mondat.Length - 1)
                {
                    Console.Write(mondat[i] + ". ");
                }
                else
                {
                    Console.Write(mondat[i] + " ");
                }
            }

            Console.ReadKey(true);


        }
    }
}
