using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(textBox1.Text);
                List<int> sucesionF = calcularFibonacciHasta(numero);
                sucesionF.ForEach(delegate (int n)
                {
                    listBox1.Items.Add(string.Format("{0}, ", n));
                });
            }
            catch (Exception)
            {
                textBox1.Text = "";
                textBox1.Focus();
            }
        }

        private List<int> calcularFibonacciHasta(int numero)
        {
            List<int> sucesionF = new List<int>();

            int primero = 0;
            int segundo = 1;
            for (int i = 0; i < numero; i++)
            {
                int anterior = primero;
                primero = segundo;
                segundo = anterior + primero;
                if (primero > numero)
                {
                    break;
                }
                sucesionF.Add(primero);
            }
            return sucesionF;
        }
    }
}
