using System;
using System.Windows.Forms;

namespace Punto_1___Dario_Zubaray
{
    public partial class Form1 : Form
    {
        int tiempo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int scrollValue = hScrollBar1.Value;
            label3.Text = scrollValue.ToString();
            tiempo = (int)Math.Ceiling((double)scrollValue / 20);

            if(tiempo == 0)
            {
                MessageBox.Show("Tiempo no puede ser 0.", "Aviso!");
                return;
            }
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            tiempo -= 1;
            label2.Text = "00:0" + tiempo;
            if (tiempo <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Tiempo Cumplido.", "Aviso!");
            }
        }

        private void HScrollBar_Changed(object sender, EventArgs e)
        {
            int scrollValue = hScrollBar1.Value;
            label3.Text = scrollValue.ToString();
        }
    }
}
