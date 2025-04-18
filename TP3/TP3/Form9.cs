using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form9 : Form
    {
        Random rnd = new Random();
        List<int> apariciones = new List<int>(5);
        int totalPorcentaje = 0;

        public Form9()
        {
            InitializeComponent();
            SetupDataGridView();
            for (int i = 0; i < 5; i++)
            {
                apariciones.Add(0);
            }
        }
        private void SetupDataGridView()
        {
            dataGridView1.Columns.Add("Numero", "Numero");
            dataGridView1.Columns.Add("Apariciones", "Apariciones");
            dataGridView1.Columns.Add("Porcentaje", "Porcentaje");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int num = rnd.Next(1, 6);
            label1.Text = SimularDado(num);
            num = rnd.Next(1, 6);
            label2.Text = SimularDado(num);

            for (int i = 0; i < 5; i++)
            {
                decimal porcentaje = (decimal) apariciones[i] / totalPorcentaje;
                dataGridView1.Rows.Add(i+1, apariciones[i], porcentaje + "%");
            }
        }

        public string SimularDado(int resultado)
        {
            totalPorcentaje++;
            switch (resultado)
            {
                case 1:
                    apariciones[0] = apariciones[0] + 1;
                    return "*";
                case 2:
                    apariciones[1] = apariciones[1] + 1;
                    return "*\n*";
                case 3:
                    apariciones[2] = apariciones[2] + 1;
                    return "*\n*\n*";
                case 4:
                    apariciones[3] = apariciones[3] + 1;
                    return "* *\n* *";
                case 5:
                    apariciones[4] = apariciones[4] + 1;
                    return "* *\n * \n* *";
                case 6:
                    apariciones[5] = apariciones[5] + 1;
                    return "* *\n* *\n* *";
                default:
                    return "";
            }
        }

    }
}
