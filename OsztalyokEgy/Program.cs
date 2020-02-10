using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyokEgy
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] tomb = new int[3];
            //Ember emberke = new Ember(152, 48, "1995.12.24");
            //Ember emberke = ember;
            //emberke.SetMagassag(145);
            //emberke.LekerMagassag() = 145;

            /*Console.WriteLine($"Az ember magassaga: {emberke.GetMagassag()} centimeter");
            Console.WriteLine($"Az ember sulya: {emberke.GetTestsuly()} kg");
            Console.WriteLine($"Az ember szuletesi eve: {emberke.GetSzuletsiEv()}");*/

            Ember[] emberTomb = new Ember[2];

            for (int i = 0; i < 2; i++)
            {
                bool letezik = false;
                Console.Write("kerem a magassagot: ");
                int magassag = Int32.Parse(Console.ReadLine());
                Console.Write("kerem a testsulyat: ");
                int testsuly = Int32.Parse(Console.ReadLine());
                Console.Write("kerem a szuletesi evet: ");
                string szuletesiEv = Console.ReadLine();
                Ember ember = new Ember();
                try
                {
                    ember = new Ember(magassag, testsuly, szuletesiEv);
                }
                catch (ArgumentException e)
                {

                    Console.WriteLine(e.Message);
                    letezik = true;
                }
                emberTomb[i] = ember;
                ember.Kiir(i + 1);
                
                emberTomb[i] = ember;
                /*Console.WriteLine($"Az {i + 1}ember magassaga: {ember.GetMagassag()} centimeter");
                Console.WriteLine($"Az {i + 1} ember sulya: {ember.GetTestsuly()} kg");
                Console.WriteLine($"Az {i + 1} ember szuletesi eve: {ember.GetSzuletsiEv()}");*/
                if (letezik) i--;
                
            }
            /* for (int i = 0; i < emberTomb.Length; i++)
             {
                 Console.WriteLine($"Az ember magassaga: {emberTomb[i].Magassag} centimeter");
                 Console.WriteLine($"Az ember sulya: {emberTomb[i].Testsuly} kg");
                 Console.WriteLine($"Az ember szuletesi eve: {emberTomb[i].SzuletesiEv}");
             }*/

            /*Ember ember = new Ember(185, 85, "1998.02.10");
            ember.Magassag = 210;*/


            /*Console.WriteLine($"Az ember magassaga: {ember.GetMagassag()} centimeter");
            Console.WriteLine($"Az ember sulya: {ember.GetTestsuly()} kg");
            Console.WriteLine($"Az ember szuletesi eve: {ember.GetSzuletsiEv()}");*/

            Console.WriteLine("A masodik ember uj magassaga");
            int ujMagassag = Convert.ToInt32(Console.ReadLine());

            try
            {
                emberTomb[1].SetMagassag(ujMagassag);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message); 
            }

            Console.ReadKey(true);
        }
    }
    class Ember
    {
        private int magassag;
        private int testsuly;
        private string szuletesiEv;
        static public string osztaly = "szoftverfejleszto";
        static public int evfolyam = 13;

        public int Magassag
        {
            get { return this.magassag; }
            set { this.magassag = value; }
        }
        public int Testsuly
        {
            get { return this.testsuly; }
            set { this.testsuly = value; }
        }
        public string SzuletesiEv
        {
            get { return this.szuletesiEv; }
            set { this.szuletesiEv = value; }
        }

        public Ember(int Magassag, int Testsuly, string SzuletesiEv)
        {
            /*if( Magassag < 0 || Magassag > 415)
                throw new ArgumentException("Nem elfogathato ertek");

            if (Testsuly < 0)
                throw new ArgumentException("Nem elfogadhato ertek");*/
    
            this.magassag = Magassag;
            this.magassag = Magassag;
            this.testsuly = Testsuly;
            this.szuletesiEv = SzuletesiEv;
        }
        public Ember()
        {

        }
        public int GetMagassag()
        {
            return this.magassag;
        }
        public void SetMagassag(int value)
        {
            if (value < 0 || value > 450)
                throw new ArgumentException("Nem jo magasssag ertek");
            this.magassag = value;
        }
        public int GetTestsuly()
        {

            return this.testsuly;
        }
        public void SetTestsuly(int value)
        {
            if (value < 0 )
                throw new ArgumentException("Nem jo testsuly ertek");
            this.testsuly = value;
        }
        public string GetSzuletsiEv()
        
        {
            return this.szuletesiEv;
        }
        public void SetSzuletesiev(string value)
        {
            this.szuletesiEv = value;
        }
        public void Kiir(int i)
        {
            Console.WriteLine($"Az {i}. ember magassga: {this.magassag}");
            Console.WriteLine($"Az {i}. ember testsuly: {this.testsuly}");
            Console.WriteLine($"Az {i}. ember szuletesi ev: {this.szuletesiEv}");
            Console.WriteLine($"Az {i}. ember osztalya: {evfolyam}/{osztaly}");
            Console.WriteLine("NA ZSA HAZA!!! NEM KELL MAR TOBB ILYEN MEGOLDAS ENNYI MAR BOVEN ELEG LESZ SOK IS MAR FINGOM SINCS HOGY MI A RETKET CSINALUNK");

        }
    }
}
