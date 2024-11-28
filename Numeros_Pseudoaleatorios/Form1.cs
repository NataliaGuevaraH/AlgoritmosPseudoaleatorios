using Numeros_Pseudoaleatorios.Algoritmos;
using Numeros_Pseudoaleatorios.Clases;
using System.Numerics;

namespace Numeros_Pseudoaleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                  textBox2.Text.Equals("") ||
                  textBox3.Text.Equals("") ||
                  textBox4.Text.Equals("") ||
                  textBox5.Text.Equals(""))
            {

                MessageBox.Show("Valor mayores a 0");
                return;
            }

            List<double> listaSalida = new List<double>();
            double semilla = Convert.ToDouble(textBox1.Text);
            int numExperimentos = Convert.ToInt32(textBox2.Text);

            Método_Cuadrado_Medio generacionNumeros = new Método_Cuadrado_Medio();
            listaSalida = generacionNumeros.GenerarValoresAleatorios(semilla, numExperimentos);
            string numbersString = string.Join(", ", listaSalida);
            MessageBox.Show(numbersString);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") ||
                  textBox2.Text.Equals("") ||
                  textBox3.Text.Equals("") ||
                  textBox4.Text.Equals("") ||
                  textBox5.Text.Equals(""))
            {

                MessageBox.Show("Valor mayores a 0");
                return;
            }

            List<int> listaSalida2 = new List<int>();
            int X0 = Convert.ToInt32(textBox1.Text);
            int numExperimentos = Convert.ToInt32(textBox2.Text);
            int t = Convert.ToInt32(textBox3.Text);
            int d = Convert.ToInt32(textBox4.Text);
            int falso = Convert.ToInt32(textBox5.Text);
            int m;
            bool sumaResta= true;

            if (falso == 0){
                sumaResta= false;
            }
            else
            {
                sumaResta = true;
            }

            m = 2 * d;

            if (BigInteger.GreatestCommonDivisor(X0, m) != 1)
            {
                MessageBox.Show("Error: Los valores x0 y m no son relativamente primos");
            }
            if ((X0) % 2==0 )
            {
                MessageBox.Show("x0 NO PUEDE SER PAR");
            }

            Multiplicativa generacionNumeros2 = new Multiplicativa();


            listaSalida2 = generacionNumeros2.GenerarValoresAleatorios2( X0,  numExperimentos,t,sumaResta,d,m);
            string numbersString = string.Join(", ", listaSalida2);
            MessageBox.Show(numbersString);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
