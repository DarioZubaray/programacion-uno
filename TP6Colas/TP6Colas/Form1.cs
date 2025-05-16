using System;
using System.Windows.Forms;

namespace TP6Colas
{
    public partial class Form1 : Form
    {
        MiQueue baja;
        MiQueue media;
        MiQueue alta;

        public Form1()
        {
            InitializeComponent();
            cbbPrioridad.SelectedIndex = 0;
            this.baja = new MiQueue();
            this.media = new MiQueue();
            this.alta = new MiQueue();
        }

        private void MostrarCola()
        {
            listView1.Clear();
            AgregarTodo(alta.Fin);
            AgregarTodo(media.Fin);
            AgregarTodo(baja.Fin);
        }

        private void AgregarTodo(MiNodo unNodo)
        {
            if(unNodo != null && unNodo.Nombre != null)
            {
                listView1.Items.Add(unNodo.Nombre);

                if(unNodo.Anterior != null)
                {
                    AgregarTodo(unNodo.Anterior);
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int prioridadOrden = cbbPrioridad.SelectedIndex;
            string nombreCliente = txtCliente.Text;
            MiNodo nodoCliente = new MiNodo()
            {
                Nombre = nombreCliente
            };

            switch(prioridadOrden)
            {
                case 0:
                    baja.Encolar(nodoCliente);
                    break;
                case 1:
                    media.Encolar(nodoCliente);
                    break;
                case 2:
                    alta.Encolar(nodoCliente);
                    break;
            }
            txtCliente.Text = "";
            MostrarCola();
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            MiNodo atendiendo = alta.Desencolar() ?? media.Desencolar() ?? baja.Desencolar();

            if (atendiendo == null)
            {
                lblAtendiendo.Text = "";
                MessageBox.Show("No hay clientes que atender");
                return;
            }

            lblAtendiendo.Text = $"Atendiendo a {atendiendo.Nombre}";
            MostrarCola();
        }
    }
}
