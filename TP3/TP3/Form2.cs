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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(textBox1.Text);
                int numero2 = Convert.ToInt32(textBox2.Text);
                int resultado = numero1 + numero2;
                lblResultado.Text = string.Format("El Resultado es: {0}", resultado);
            }
            catch (Exception)
            {
                limpiar();
            };
        }

        private void limpiar()
        {
            textBox1.Clear();
            textBox2.Clear();
            lblResultado.Text = "Ingrese dos valores númericos.";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
