using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Pseudoaleatorios.Algoritmos
{
    public  class Multiplicativa
    {
        public List<int> GenerarValoresAleatorios2(int X0, int numExperimentos, int t,bool sumaResta, int d,int m)
        {
            List<int> listaSalida = new List<int>();

            int a,x1;

            if (sumaResta == true)
            {
                a = 8 * t + 3;
            }
            else
            {
                a = 8 * t - 3;
            }




            for (int i = 0; i< numExperimentos; i++)
            {
                listaSalida.Add(X0);
                x1=(a * X0) % m;
                X0= x1;

            }



            return listaSalida;
        }

    }
}
