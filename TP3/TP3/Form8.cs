using System;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form8 : Form
    {

        Random rnd = new Random();
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = rnd.Next(1, 6);
            label1.Text = SimularDado(num);
        }

        public static string SimularDado(int resultado)
        {
            switch (resultado)
            {
                case 1:
                    return "*";
                case 2:
                    return "*\n*";
                case 3:
                    return "*\n*\n*";
                case 4:
                    return "* *\n* *";
                case 5:
                    return "* *\n * \n* *";
                case 6:
                    return "* *\n* *\n* *";
                default:
                    return "";
            }
        }
    }
}
