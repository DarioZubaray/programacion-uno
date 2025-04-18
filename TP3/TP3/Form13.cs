using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            this.openFileDialog1.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos (*.*)|*.*";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = openFileDialog1.ShowDialog();
            if(resultado == DialogResult.OK)
            {
                try
                {
                    // Obtener la ruta del archivo seleccionado
                    string rutaArchivo = openFileDialog1.FileName;

                    // Cargar la imagen en el PictureBox
                    pictureBox1.Image = Image.FromFile(rutaArchivo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
