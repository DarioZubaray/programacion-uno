using System;
using System.Windows.Forms;

namespace LaboratorioGrupal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text != null ? txtUser.Text : "No ingresado";
            string nacimiento = dateTimePicker1.Text;
            string sexo = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
            string estudios = comboBox1.Text != null ? comboBox1.Text : "Sin estudios";
            string mensaje = "Se enviaran los siguientes datos:\n" + 
                "\nUsuario: " + user + 
                "\nNacimiento: " + nacimiento + 
                "\nSexo: " + sexo + 
                "\nEstudios: " + estudios;
            MessageBox.Show(mensaje, "Registro");
            Close();
        }
    }
}
