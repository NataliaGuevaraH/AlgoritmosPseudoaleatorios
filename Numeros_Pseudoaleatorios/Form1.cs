using Numeros_Pseudoaleatorios.Algoritmos;
using Numeros_Pseudoaleatorios.Clases;

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

            List<double> listaSalida = new List<double>();
            double semilla = Convert.ToDouble(textBox1.Text);
            int numExperimentos = Convert.ToInt32(textBox2.Text);

            Método_Cuadrado_Medio generacionNumeros = new Método_Cuadrado_Medio();
            listaSalida = generacionNumeros.GenerarValoresAleatorios( semilla, numExperimentos);
            string numbersString = string.Join(", ", listaSalida);
            MessageBox.Show(numbersString);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
