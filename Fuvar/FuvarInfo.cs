﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Fuvar
{
    class FuvarInfo
    {
        public int Azonosito { get; set; }
        public string IdoBelyegzo { get; set; }
        public int Idotartam { get; set; }
        public double Tavolsag { get; set; }
        public double Viteldij { get; set; }
        public double Borravalo { get; set; }
        public string FizetesModja { get; set; }


        public FuvarInfo(int az, string ib, int it, double mt, double vd, double bv, string fm)
        {
            this.Azonosito = az;
            this.IdoBelyegzo = ib;
            this.Idotartam = it;
            this.Tavolsag = mt;
            this.Viteldij = vd;
            this.Borravalo = bv;
            this.FizetesModja = fm;
        }
    }
}
