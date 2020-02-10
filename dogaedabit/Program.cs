using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogaedabit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem a szot: ");
            string szo = Console.ReadLine();
            
            Dupplabetu elso = new Dupplabetu(szo);

            Console.WriteLine($"Az szoban van e kettos betu: {elso.Duplabetuu(szo)}");

            Console.ReadKey(true);

        }

    }
}
