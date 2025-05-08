using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace TrabajandoConListas
{
    public partial class Form1 : Form
    {
        BindingList<Paciente> listaPacientes;
        public Form1()
        {
            InitializeComponent();
            listaPacientes = new BindingList<Paciente>();
            listaPacientes = CargarDatos();
            dataGridView1.DataSource = listaPacientes;
            CrearBotonEditar();
            CrearBotonEliminar();

            dataGridView1.CellClick += dataGridView1_CellClick;
        }

        private void CrearBotonEliminar()
        {

            DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
            btnCol.HeaderText = "Eliminar";
            btnCol.Name = "btnEliminar";
            btnCol.Text = "🗑";
            btnCol.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnCol);
        }

        private void CrearBotonEditar()
        {
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
            btnEdit.HeaderText = "Editar";
            btnEdit.Name = "btnEditar";
            btnEdit.Text = "✏";
            btnEdit.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnEdit);
        }

        private BindingList<Paciente> CargarDatos()
        {
            BindingList<Paciente> listaInicial = new BindingList<Paciente>
            {
                new Paciente { Codigo = "00A1", Nombre = "Jose", Apellido = "Lopez", Direccion = "Balcarse 50", Telefono = "011-123456" },
                new Paciente { Codigo = "00A2", Nombre = "Juan", Apellido = "Lopez", Direccion = "Balcarse 50", Telefono = "011-123457" }
            };

            return listaInicial;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["btnEliminar"].Index && e.RowIndex >= 0)
            {
                string mensaje = "¿Seguro que deseas eliminar este paciente?";
                DialogResult result = MessageBox.Show(mensaje, "Confirmar", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["btnEditar"].Index && e.RowIndex >= 0)
            {
                if(!txtCodigo.Enabled)
                {
                    SwitchCreacion();
                }
                btnAgregar.Visible = false;
                btnAgregarEdicion.Visible = true;
                btnCancelarEdicion.Visible = true;

                Paciente pacienteSeleccionado = listaPacientes[e.RowIndex];
                txtCodigo.Text = pacienteSeleccionado.Codigo;
                txtNombre.Text = pacienteSeleccionado.Nombre;
                txtApellido.Text = pacienteSeleccionado.Apellido;
                txtDireccion.Text = pacienteSeleccionado.Direccion;
                txtTelefono.Text = pacienteSeleccionado.Telefono;
            }
        }

        private void btnCreacion_Click(object sender, System.EventArgs e)
        {
            SwitchCreacion();
            txtCodigo.Focus();
        }

        private void SwitchCreacion()
        {
            btnCreacion.Enabled = !btnCreacion.Enabled;
            txtCodigo.Enabled = !txtCodigo.Enabled;
            txtNombre.Enabled = !txtNombre.Enabled;
            txtApellido.Enabled = !txtApellido.Enabled;
            txtDireccion.Enabled = !txtDireccion.Enabled;
            txtTelefono.Enabled = !txtTelefono.Enabled;
            btnAgregar.Enabled = !btnAgregar.Enabled;

        }

        private void btnAgregar_Click(object sender, System.EventArgs e)
        {
            if(ValidarTextBoxCreacion())
            {
                Paciente nuevoPaciente = new Paciente
                {
                    Codigo = txtCodigo.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Direccion = txtDireccion.Text,
                    Telefono = txtTelefono.Text
                };
                listaPacientes.Add(nuevoPaciente);
                SwitchCreacion();
                btnCreacion.Focus();
                LimpiarTextBoxCreacion();
            }
        }

        private bool ValidarTextBoxCreacion()
        {
            string codigo = txtCodigo.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string direccion = txtDireccion.Text;
            string telefono = txtTelefono.Text;

            return codigo != "" && nombre != "" && apellido != "" && direccion != "" && direccion != "" && telefono != "";
        }

        private void LimpiarTextBoxCreacion()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void btnCancelarEdicion_Click(object sender, System.EventArgs e)
        {
            LimpiarTextBoxCreacion();
            btnAgregar.Visible = true;
            btnAgregarEdicion.Visible = false;
            btnCancelarEdicion.Visible = false;
            SwitchCreacion();
        }

        private void btnAgregarEdicion_Click(object sender, System.EventArgs e)
        {
            string codigoPaciente = txtCodigo.Text;
            Paciente pacienteEditar = null;

            foreach (Paciente p in listaPacientes)
            {
                if (p.Codigo == codigoPaciente)
                {
                    pacienteEditar = p;
                    break;
                }
            }

            if (pacienteEditar != null)
            {
                pacienteEditar.Nombre = txtNombre.Text;
                pacienteEditar.Apellido = txtApellido.Text;
                pacienteEditar.Direccion = txtDireccion.Text;
                pacienteEditar.Telefono = txtTelefono.Text;

                dataGridView1.Refresh();
                LimpiarTextBoxCreacion();
                btnAgregar.Visible = true;
                btnAgregarEdicion.Visible = false;
                btnCancelarEdicion.Visible = false;
                SwitchCreacion();
            }
        }
    }
}
