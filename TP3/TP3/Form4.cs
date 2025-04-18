using System;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtNumero1.Text = "";
            txtNumero1.Focus();
            txtNumero2.Text = "";
            lblOperacion.Text = "";
            lblResultado.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);
                int resultado = numero1 + numero2;
                lblOperacion.Text = string.Format("{0} + {1} =", numero1, numero2);
                lblResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                limpiar();
            }
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);
                int resultado = numero1 - numero2;
                lblOperacion.Text = string.Format("{0} - {1} =", numero1, numero2);
                lblResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                limpiar();
            }
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);
                int resultado = numero1 * numero2;
                lblOperacion.Text = string.Format("{0} x {1} =", numero1, numero2);
                lblResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                limpiar();
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);
                if(numero2 == 0)
                {
                    limpiar();
                    MessageBox.Show("No es posible dividir por cero!", "Advertencia");
                }
                decimal resultado = (decimal) numero1 / numero2;
                lblOperacion.Text = string.Format("{0} ÷ {1} =", numero1, numero2);
                lblResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                limpiar();
            }
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);
                double resultado = Math.Pow(numero1, numero2);
                lblOperacion.Text = string.Format("{0} ^ {1} =", numero1, numero2);
                lblResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                limpiar();
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);
                double resultado = Math.Sqrt(numero1);
                lblOperacion.Text = string.Format("√ {0} =", numero1);
                lblResultado.Text = resultado.ToString();
            }
            catch (Exception)
            {
                limpiar();
            }
        }
    }
}
