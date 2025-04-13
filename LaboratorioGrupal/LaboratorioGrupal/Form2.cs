using System;
using System.Windows.Forms;

namespace LaboratorioGrupal
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }

        private void descargar(object sender, EventArgs e)
        {
            int velocidad = (int)numericUpDown1.Value;
            progressBar1.Value = Math.Min(progressBar1.Value + velocidad, progressBar1.Maximum);

            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                bool automatico = checkBox1.Checked;
                string mensaje = "¡Descarga completa!\n" +
                    (automatico ? "Se recordará la proxima vez" : "");
                MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
