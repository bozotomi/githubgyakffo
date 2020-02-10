using System;
using System.Collections.Generic;
using System.Text;

namespace dogaedabit
{
    class Dupplabetu
    {
        public string Szo { get; set; }

        public Dupplabetu(string szo)
        {
            this.Szo = szo;
        }
        public bool Duplabetuu(string szo)
        {

            for (int i = 0; i < szo.Length - 1; i++)
            {
                if (szo[i] == szo[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
    }
}
