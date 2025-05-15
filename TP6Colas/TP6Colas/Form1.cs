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
            AgregarTodo(alta.Inicio);
            AgregarTodo(media.Inicio);
            AgregarTodo(baja.Inicio);
        }

        private void AgregarTodo(MiNodo unNodo)
        {
            if(unNodo != null && unNodo.Nombre != null)
            {
                listView1.Items.Add(unNodo.Nombre);

                if(unNodo.Siguiente != null)
                {
                    AgregarTodo(unNodo.Siguiente);
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
            MiNodo atendiendoAlta = alta.Desencolar();
            if(atendiendoAlta == null)
            {
                MiNodo atendiendoMedia = media.Desencolar();
                if(atendiendoMedia == null)
                {
                    MiNodo atendiendoBaja = baja.Desencolar();
                    if(atendiendoBaja == null)
                    {
                        lblAtendiendo.Text = "";
                        MessageBox.Show("No hay clientes que atender");
                        return;
                    }
                    lblAtendiendo.Text = "Atendiendo a " + atendiendoBaja.Nombre;
                    MostrarCola();
                    return;
                }
                lblAtendiendo.Text = "Atendiendo a " + atendiendoMedia.Nombre;
                MostrarCola();
                return;
            }
            lblAtendiendo.Text = "Atendiendo a " + atendiendoAlta.Nombre;

            MostrarCola();
            return;
        }
    }
}
