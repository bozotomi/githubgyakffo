using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EuCsatlakozas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> tagallamok = new List<string[]>();
            using (StreamReader sr = new StreamReader("EUcsatlakozas.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] tomb = sor.Split(';');
                    tagallamok.Add(tomb);

                }

               
            }

            Console.WriteLine($"3. feladat: EU tagalllamainak szama: {tagallamok.Count} db");


            int darab = 0;

            for (int i = 0; i < tagallamok.Count; i++)
            {
                if (tagallamok[i][1].Substring(0, 4) == "2007")
                {
                    darab++;
                }
               
            }

            Console.WriteLine($"4. feladat: 2007-ben {darab} orszag csatlakozott.");

            

            for (int i = 0; i < tagallamok.Count; i++)
            {
                if (tagallamok[i][0] == "Magyarország")
                if (tagallamok[i][0] == "Magyarország")
                {
                    
                    Console.WriteLine($"5. feladat: Magyarorszag csatlakozassanak a datuma: {tagallamok[i][1]} ");
                }
                
            }
      

            Console.ReadKey(true);
        }
    }
}
