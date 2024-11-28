using System;
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
        public Congruencial() { }

        public Congruencial(double semilla,int numExperimentos)
        {
            Semilla = semilla;
            NumExperimentos = numExperimentos;
        }
    }

}
