using System;
using System.Windows.Forms;

namespace Tp12_IntegracionI
{
    public partial class Form1 : Form
    {
        public const int MAXIMO_PASAJEROS = 20;
        private string[] pasajeros = {};

        /*
         * Se configura la posicion inicial del formulario al centro de la pantalla
         * Se configura la lista en modo un abajo del otro
         */
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lstPasajeros.View = View.List;
        }

        /*
         * Se configura el valor vacio al campo de texto de pasajeros y se pone el foco para continuar escribiendo
         */
        private void LimpiarPasajero()
        {
            txtPasajero.Text = "";
            txtPasajero.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nuevoPasajero = txtPasajero.Text;
            // Se comprueba que si NO se ingresó, se devuelve el foco para continuar
            if (string.IsNullOrWhiteSpace(nuevoPasajero))
            {
                LimpiarPasajero();
                return;
            }
            // Se comprueba que no se haya alcanzado el valor maximo de pasajeros, y se muestra un mensaje
            if (lstPasajeros.Items.Count >= MAXIMO_PASAJEROS)
            {
                string mensaje = "No se pueden agregar más de 19 elementos.";
                MessageBox.Show(mensaje, "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Se amplia el array y se agrega el nuevo valor
            Array.Resize(ref pasajeros, pasajeros.Length + 1);
            pasajeros[pasajeros.Length - 1] = nuevoPasajero;

            // Se muestra todos los pasajeros y se limpia y pone el foco para ingresar uno nuevo
            ListarPasajeros();
            LimpiarPasajero();
        }

        /*
         * Al presionar "Enter" se invoca el evento del boton "Anotar"
         */
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        /*
         * Se limpia el listView
         * Se agrega cada valor del array en un barrida foreach
         * Se comprueba si se alcanzó el límite para informar en un mensaje
         */
        private void ListarPasajeros()
        {
            lstPasajeros.Clear();
            foreach (string pasajero in pasajeros)
            {
                lstPasajeros.Items.Add(pasajero);
            }

            if (pasajeros.Length == MAXIMO_PASAJEROS)
            {
                string mensaje = "La combi está lista para salir.";
                MessageBox.Show(mensaje, "En Marcha!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /*
         * Se comprueba el total de pasajeros en espera
         *      de ser mayor o igual a 1: se limpian el array y los Items del listview
         *      de ser menor a 1: Se informa un mensaje la nueva terminal de destino
         */
        private void button2_Click(object sender, EventArgs e)
        {
            int totalPasajeros = pasajeros.Length;
            if(totalPasajeros >= 1)
            {
                pasajeros = new string[0];
                ListarPasajeros();

                string mensaje = $"La combi ha salido con {totalPasajeros} pasajeros.";
                MessageBox.Show(mensaje, "Buen Viaje!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string nuevaTerminal = "Puerto Madero";
                string mensaje = $"La combi esta vacia debe concurrir a la terminal de {nuevaTerminal}.";
                MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
