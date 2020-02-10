using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabitelso
{
    class Sztingek
    {
        public string Szoveg { get; set; }
        public string Elso { get; set; }
        public string Masodik { get; set; }

        public Sztingek(string szoveg)
        {
            this.Szoveg = szoveg;
        }
        public bool EgyyenloHosszuak(Sztingek masik)
        {
            if (this.Szoveg.Length == masik.Szoveg.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Sztingek(string a, string b)
        {
            this.Elso = a;
            this.Masodik = b;
        }
        public string Osszefuz()
        {
            return this.Masodik + " , " + this.Elso;
        }
        public bool VanESpaceElso()
        {
            if (this.Elso.Contains(" "))
            {
                return true; 
            }
            else
            {
                return false;
            }
        }
        public bool VanESpaceMAsodik()
        {
            bool vanE = false;

            for (int i = 0; i < this.Elso.Length; i++)
            {
                if (this.Elso[i] == ' ')
                {
                    vanE = true;
                }
            }


            return vanE;
        }
    }
}
