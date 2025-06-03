using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TP8_Arboles
{
    public partial class Form1 : Form
    {
        ArbolBinario arbol = new ArbolBinario();

        public Form1()
        {
            InitializeComponent();
            lblSelected.Text = "Agregar a Raiz";
        }

        private void txtValor_Click(object sender, EventArgs e)
        {
            if(treeView1.SelectedNode != null)
            {
                lblSelected.Text = "Agregar a " + treeView1.SelectedNode.Text;
            }
        }

        private void LimpiarFormulario()
        {
            txtValor.Text = "";
            treeView1.Focus();
        }

        private void btnAgregarRaiz_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text)) return;

            if (treeView1.Nodes.Count > 0)
            {
                var r = MessageBox.Show(
                    "¿Seguro que desea reemplazar la raiz?",
                    "Confirmar reemplazo",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (r.Equals(DialogResult.No)) return;
            }

            arbol.Raiz = new Nodo(txtValor.Text);
            treeView1.Nodes.Clear();
            treeView1.Nodes.Add(new TreeNode(txtValor.Text));
            LimpiarFormulario();
        }

        private void btnAgregarIzquierda_Click(object sender, EventArgs e)
        {
            AgregarNodo(lado: "izquierda");
        }

        private void btnAgregarDerecha_Click(object sender, EventArgs e)
        {
            AgregarNodo(lado: "derecha");
        }

        private void AgregarNodo(string lado)
        {
            if (treeView1.SelectedNode == null || string.IsNullOrWhiteSpace(txtValor.Text)) return;

            string valorPadre = treeView1.SelectedNode.Text;
            Nodo nodoPadre = arbol.Buscar(arbol.Raiz, valorPadre);
            if (nodoPadre == null) return;

            Nodo nuevoNodo = new Nodo(txtValor.Text);
            TreeNode nuevoTreeNode = new TreeNode(txtValor.Text);

            if (lado == "izquierda")
            {
                if (nodoPadre.Izquierda != null)
                {
                    var r = MessageBox.Show(
                        "Ya existe un hijo izquierdo. ¿Deseas reemplazarlo?",
                        "Confirmar reemplazo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    if (r == DialogResult.No) return;

                    // Eliminar hijo izquierdo existente en el TreeView
                    if (treeView1.SelectedNode.Nodes.Count > 0)
                    {
                        treeView1.SelectedNode.Nodes.RemoveAt(0);
                    }
                }

                nodoPadre.Izquierda = nuevoNodo;
                treeView1.SelectedNode.Nodes.Insert(0, nuevoTreeNode);
            }
            else if (lado == "derecha")
            {
                if (nodoPadre.Derecha != null)
                {
                    var r = MessageBox.Show(
                        "Ya existe un hijo derecho. ¿Deseas reemplazarlo?",
                        "Confirmar reemplazo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );
                    if (r == DialogResult.No) return;

                    // Eliminar hijo derecho existente en el TreeView
                    if (treeView1.SelectedNode.Nodes.Count > 1)
                    {
                        treeView1.SelectedNode.Nodes.RemoveAt(1);
                    }
                }

                nodoPadre.Derecha = nuevoNodo;

                if (treeView1.SelectedNode.Nodes.Count == 0)
                {
                    // Si no había ningún hijo, agregamos un hijo izquierdo "nulo"
                    treeView1.SelectedNode.Nodes.Add(new TreeNode("<vacio>"));
                }

                if (treeView1.SelectedNode.Nodes.Count == 1)
                {
                    // Insertamos el hijo derecho en la posición 1
                    treeView1.SelectedNode.Nodes.Insert(1, nuevoTreeNode);
                }
                else
                {
                    treeView1.SelectedNode.Nodes[1] = nuevoTreeNode;
                }
            }

            treeView1.SelectedNode.Expand();
            LimpiarFormulario();
        }

        private void btnPreorden_Click(object sender, EventArgs e)
        {
            var recorrido = new List<string>();
            arbol.PreOrden(arbol.Raiz, recorrido);
            MostrarRecorrido(recorrido);
        }

        private void btnInorden_Click(object sender, EventArgs e)
        {
            var recorrido = new List<string>();
            arbol.InOrden(arbol.Raiz, recorrido);
            MostrarRecorrido(recorrido);
        }

        private void btnPostorden_Click(object sender, EventArgs e)
        {
            var recorrido = new List<string>();
            arbol.PostOrden(arbol.Raiz, recorrido);
            MostrarRecorrido(recorrido);
        }

        private void MostrarRecorrido(List<string> recorrido)
        {
            lstRecorrido.Items.Clear();
            foreach (var item in recorrido)
            {
                lstRecorrido.Items.Add(item);
            }
        }

    }
}
