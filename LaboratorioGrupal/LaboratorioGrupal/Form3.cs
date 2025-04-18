using System;
using System.Windows.Forms;

namespace LaboratorioGrupal
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;

            comboBox1.Items.AddRange(new string[] { "Alta", "Media", "Baja" });
            comboBox1.SelectedIndex = 1; // Por defecto: Media
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nuevaTarea = textBox1.Text.Trim();
            string prioridad = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(nuevaTarea) && !string.IsNullOrEmpty(prioridad))
            {
                string tareaConPrioridad = $"{nuevaTarea} (Prioridad: {prioridad})";
                checkedListBox1.Items.Add(tareaConPrioridad);

                textBox1.Clear();
                comboBox1.SelectedIndex = 1; // volver a "Media"
                ActualizarProgreso();
            }
            else
            {
                MessageBox.Show("Por favor complete la tarea y seleccione una prioridad.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox1.CheckedItems.Count - 1; i >= 0; i--)
            {
                object tarea = checkedListBox1.CheckedItems[i];
                listBox1.Items.Add(tarea);
                checkedListBox1.Items.Remove(tarea);
            }

            ActualizarProgreso();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            checkedListBox1.Items.Clear();
            listBox1.Items.Clear();
            progressBar1.Value = 0;
        }

        private void ActualizarProgreso()
        {
            int total = checkedListBox1.Items.Count + listBox1.Items.Count;
            int completadas = listBox1.Items.Count;

            if (total == 0)
            {
                progressBar1.Value = 0;
            }
            else
            {
                int porcentaje = (completadas * 100) / total;
                progressBar1.Value = porcentaje;
            }
        }
    }
}