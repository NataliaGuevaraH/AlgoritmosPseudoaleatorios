using Numeros_Pseudoaleatorios.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_Pseudoaleatorios.Algoritmos
{
    public class Método_Cuadrado_Medio
    {
        public List<double> GenerarValoresAleatorios(double semilla, int numExperimentos)
        {
            List<double> listaRn = new List<double>();

            string transform,Mrn;
            double Rn,val1,val2,val3,val4;

            for (int i = 0; i < numExperimentos; i++)
            {
                listaRn.Add(semilla);
                Rn = Math.Pow(semilla, 2);
                transform = Rn.ToString();
                Mrn = transform.Substring(1, (transform.Length)-1);

                if (transform.Length <= 2)
                {
                    val1 = Rn;
                    val2 = 0;
                    //listaRn.Add(val1);
                    semilla = val1;
                }
                else if (transform.Length == 3)
                {
                    val3 = double.Parse(Mrn);
                    val1 = val3;
                    val2 = 0;
                    //listaRn.Add(val1);
                    semilla = val1;
                }
                else
                {

                    val3 = double.Parse(Mrn.Substring(0,3));
                    val4 = double.Parse(Mrn.Substring(0, (transform.Length)-1));
                    val1 = val3;
                    val2 = val4;
                    //listaRn.Add(val1);
                    semilla = val1;

                }
                


            }

            return listaRn;

        }
}
}
