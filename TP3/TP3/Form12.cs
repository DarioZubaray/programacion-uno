using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = colorDialog1.ShowDialog();
            if (resultado == DialogResult.OK)
            {

                Color colorSeleccionado = colorDialog1.Color;

                this.BackColor = colorSeleccionado;
            }
        }
    }
}
