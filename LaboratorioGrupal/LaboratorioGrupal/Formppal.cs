using System;
using System.Windows.Forms;

namespace LaboratorioGrupal
{
    public partial class Formppal : Form
    {
        public Formppal()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnform2_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }

        private void btnformMDI_Click(object sender, EventArgs e)
        {
            MDIParent1 mdiParent = new MDIParent1();
            mdiParent.Show();
        }
    }
}
