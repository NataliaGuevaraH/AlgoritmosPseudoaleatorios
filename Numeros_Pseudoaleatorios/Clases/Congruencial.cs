﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Pseudoaleatorios.Clases
{
    public class Congruencial
    {
        public double Semilla { get; set; }
        public int NumExperimentos {  get; set; }

        public int M {  get; set; }
        public Congruencial() { }

        public Congruencial(double semilla,int numExperimentos, int m)
        {
            Semilla = semilla;
            NumExperimentos = numExperimentos;
            M = m;
        }
    }

}
