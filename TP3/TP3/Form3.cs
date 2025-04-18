using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(txtNumero.Text);
                listNumeros.Items.Add(numero);
            }
            catch (Exception)
            {
                
            }
            txtNumero.Text = "";
            txtNumero.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int suma = 0;
            foreach (object item in listNumeros.Items)
            {
                if (item is int numero)
                {
                    suma += numero;
                }
                else if (int.TryParse(item.ToString(), out int numeroParseado))
                {
                    suma += numeroParseado;
                }
                else
                {
                    Console.WriteLine($"Advertencia: El elemento '{item}' no es un número entero y se omitirá.");
                }
            }

            lblResultado.Text = "La suma de todos los números es " + suma;
        }
    }
}
