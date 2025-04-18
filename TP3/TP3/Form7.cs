using System;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Add("Monto", "Monto");
            dataGridView1.Columns.Add("Tasa", "Tasa");
            dataGridView1.Columns.Add("Dias", "Días");
            dataGridView1.Columns.Add("Interes", "Interés");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int monto = Convert.ToInt32(textBox1.Text);
                int tasa = Convert.ToInt32(textBox2.Text);
                int dias = Convert.ToInt32(textBox3.Text);
                decimal interes = (decimal) (monto * tasa * dias) / 36500;
                dataGridView1.Rows.Add(monto, tasa, dias, Decimal.Round(interes, 2));
            }
            catch (Exception)
            {
                textBox1.Text = "";
                textBox1.Focus();
                textBox2.Text = "";
                textBox3.Text = "";
                throw;
            }
        }
    }
}
