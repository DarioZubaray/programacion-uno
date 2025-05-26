using System;
using System.Windows.Forms;

namespace Punto_2___Dario_Zubaray
{
    public partial class Form1 : Form
    {
        private Cola colaClientes;
        public Form1()
        {
            InitializeComponent();
            colaClientes = new Cola();

            numImporte.DecimalPlaces = 2;
            numImporte.Minimum = 0;
            numImporte.Maximum = 1000000;
            numImporte.ThousandsSeparator = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal importe = numImporte.Value;
            bool esSocio = checkBox1.Checked;

            if(nombre == "" || importe <= 0)
            {
                MessageBox.Show("Nombre e importe son requeridos", "Verifique ingreso!");
                return;
            }

            Cliente nuevoCliente = new Cliente
            {
                Codigo = nombre,
                Importe = importe,
                EsSocio = esSocio
            };

            Nodo nuevoNodo = new Nodo
            {
                Cliente = nuevoCliente
            };

            colaClientes.Encolar(nuevoNodo);
            MostrarColaAtencion();
            LimpiarCamposCliente();
            txtNombre.Focus();
        }

        private void MostrarColaAtencion()
        {
            listView1.Clear();
            AgregarTodos(colaClientes.Inicio);
        }

        private void AgregarTodos(Nodo unNodo)
        {
            if (unNodo != null && unNodo.Cliente != null)
            {
                listView1.Items.Add(unNodo.Cliente.ToString());

                if (unNodo.Siguiente != null)
                {
                    AgregarTodos(unNodo.Siguiente);
                }
            }
        }

        private void LimpiarCamposCliente()
        {
            txtNombre.Text = "";
            numImporte.Value = 0;
            checkBox1.Checked = false;
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            Nodo clienteAtendido = colaClientes.Desencolar();
            if (clienteAtendido == null)
            {
                lblClienteAtendido.Text = "";
                MessageBox.Show("No hay clientes que atender");
                return;
            }

            lblClienteAtendido.Text = $"Cobrando ${clienteAtendido.Cliente.Importe} a {clienteAtendido.Cliente.Codigo}";
            MostrarColaAtencion();
        }
    }
}
