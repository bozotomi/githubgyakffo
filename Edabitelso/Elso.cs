using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edabitelso
{
    class Elso
    {
        public int ElsoSzam { get; set; }
        public bool Logikaiertek { get; set; }


        public Elso(int a)
        {
            this.ElsoSzam = a;
        }
        public Elso(bool b)
        {
            this.Logikaiertek = b;
        }

        public int Sum(Elso ertek)
        {
            return this.ElsoSzam + ertek.ElsoSzam;
        }
        public int Kovetkezo()
        {
            return ElsoSzam + 1;
        }
        static double HaromszogTerulet(double alap, double magassag)
        {
            return (alap * magassag) / 2;
        }
        public int Maradek(Elso ertek)
        {
            return this.ElsoSzam % ertek.ElsoSzam;
        }
        public bool Elojel()
        {
            if (this.ElsoSzam <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Megfordit()
        {
            return this.Logikaiertek;
        }
        public bool OttelOszthato()
        {
            if (this.ElsoSzam % 5 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
