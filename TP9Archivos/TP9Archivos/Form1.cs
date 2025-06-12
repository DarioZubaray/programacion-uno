using System.Windows.Forms;

namespace TP9Archivos
{
    public partial class Form1 : Form
    {
        GestorAlumnos gestor;
        string legajoSeleccionado;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnModificacion.Enabled = false;
            gestor = new GestorAlumnos();
            LlenarGrilla();
        }

        private void LlenarGrilla()
        {
            this.lstListado.DataSource = null;
            this.lstListado.DataSource = gestor.Listar();
        }

        private void LimpiarCampos()
        {
            txtLegajo.Text = "";
            txtLegajo.Focus();
            txtApellidoNombre.Text = "";
            txtCategoria.Text = "";
        }

        private void btnAlta_Click(object sender, System.EventArgs e)
        {
            string legajo = txtLegajo.Text;
            string apellidoNombre = txtApellidoNombre.Text;
            string categoria = txtCategoria.Text;

            if(legajo.Trim().Equals(string.Empty) || apellidoNombre.Trim().Equals(string.Empty)
                || categoria.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Debe completar todos los campos para el ingreso", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLegajo.Focus();
                return;
            }

            Alumno nuevoAlumno = new Alumno()
            {
                Legajo = legajo,
                ApellidoNombre = apellidoNombre,
                Categoria = categoria
            };

            gestor.Alta(nuevoAlumno);
            LimpiarCampos();
            LlenarGrilla();
        }

        private void btnBaja_Click(object sender, System.EventArgs e)
        {
            if (this.lstListado.SelectedIndex != -1)
            {
                Alumno seleccionado = new Alumno(this.lstListado.SelectedItem.ToString());
                gestor.Baja(seleccionado.Legajo);
                LlenarGrilla();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            btnModificacion.Enabled = lstListado.SelectedItems.Count == 1;
        }

        private void btnModificacion_Click(object sender, System.EventArgs e)
        {
            Alumno seleccionado = new Alumno(this.lstListado.SelectedItem.ToString());
            legajoSeleccionado = seleccionado.Legajo;
            txtLegajo.Text = seleccionado.Legajo;
            txtApellidoNombre.Text = seleccionado.ApellidoNombre;
            txtCategoria.Text = seleccionado.Categoria;
            btnAlta.Enabled = false;
            btnModificacion.Enabled = false;
            btnActualizar.Visible = true;
        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            string legajo = txtLegajo.Text;
            string apellidoNombre = txtApellidoNombre.Text;
            string categoria = txtCategoria.Text;

            if (legajo.Trim().Equals(string.Empty) || apellidoNombre.Trim().Equals(string.Empty)
                || categoria.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Debe completar todos los campos para el ingreso", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLegajo.Focus();
                return;
            }

            Alumno nuevoAlumno = new Alumno()
            {
                Legajo = legajo,
                ApellidoNombre = apellidoNombre,
                Categoria = categoria
            };

            gestor.Modificar(legajoSeleccionado, nuevoAlumno);
            legajoSeleccionado = "";
            LimpiarCampos();
            btnAlta.Enabled = true;
            btnActualizar.Visible = false;
            LlenarGrilla();
        }

        private void btnSalir_Click(object sender, System.EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea salir?", "Aviso!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.OK))
            {
                Application.Exit();
            }
        }

    }
}
