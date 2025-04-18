using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int numero1 = Convert.ToInt32(txtNumero1.Text);
                int numero2 = Convert.ToInt32(txtNumero2.Text);

                List<int> numerosPrimos = EncontrarPrimosEnRangoDirecto(numero1, numero2);
                numerosPrimos.ForEach(delegate (int numeroP)
                {
                    listNumPrimos.Items.Add(string.Format("{0}, ", numeroP));
                });
            }
            catch (Exception)
            {
                txtNumero1.Text = "";
                txtNumero1.Focus();
                txtNumero2.Text = "";
            }
        }

        private List<int> EncontrarPrimosEnRangoDirecto(int inicio, int fin)
        {
            if (inicio < 2)
            {
                inicio = 2;
            }

            List<int> primosEnRango = new List<int>();
            for (int i = inicio; i <= fin; i++)
            {
                if (EsPrimo(i))
                {
                    primosEnRango.Add(i);
                }
            }
            return primosEnRango;
        }

        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero <= 3) return true;

            // Si el número es divisible por 2 o 3, no es primo
            if (numero % 2 == 0 || numero % 3 == 0) return false;

            // Revisar solo los números de la forma 6k ± 1 hasta la raíz cuadrada del número
            for (int i = 5; i * i <= numero; i = i + 6)
            {
                if (numero % i == 0 || numero % (i + 2) == 0)
                    return false;
            }

            return true;
        }

    }
}
