using System;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form1 : Form
    {
        public Form1()
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
                MessageBox.Show(string.Format("La suma es {0}", resultado));
            } catch (Exception)
            {
                textBox1.Clear();
                textBox2.Clear();
            }
        }
    }
}
