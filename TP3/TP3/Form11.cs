using System;
using System.Drawing;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form11 : Form
    {
        bool turnoEquis = true;
        String[,] matriz = { { "1", "2", "3" }, { "4", "5", "6" }, { "7", "8", "9" } };

        public Form11()
        {
            InitializeComponent();
        }

        private void jugar(Button boton)
        {
            if (turnoEquis)
            {
                boton.Text = "X";
                boton.BackColor = Color.Beige;
                turnoEquis = false;
                label1.Text = "Turno de O";
            }
            else
            {
                boton.Text = "O";
                boton.BackColor = Color.Coral;
                turnoEquis = true;
                label1.Text = "Turno de X";
            }
        }

        private void calcularGanador()
        {
            string ganador = turnoEquis ? "O" : "X";
            bool hayGanador = false;
            if (matriz[0,0] == matriz[0,1] && matriz[0, 0] == matriz[0, 2])
            {
                hayGanador = true;
            }
            if (matriz[1, 0] == matriz[1, 1] && matriz[1, 0] == matriz[1, 2])
            {
                hayGanador = true;
            }
            if (matriz[2, 0] == matriz[2, 1] && matriz[2, 0] == matriz[2, 2])
            {
                hayGanador = true;
            }

            if (matriz[0, 0] == matriz[1, 0] && matriz[0, 0] == matriz[2, 0])
            {
                hayGanador = true;
            }
            if (matriz[0, 1] == matriz[1, 1] && matriz[0, 1] == matriz[2, 1])
            {
                hayGanador = true;
            }
            if (matriz[0, 2] == matriz[1, 2] && matriz[0, 2] == matriz[2, 2])
            {
                hayGanador = true;
            }

            if (matriz[0, 0] == matriz[1, 1] && matriz[0, 0] == matriz[2, 2])
            {
                hayGanador = true;
            }
            if (matriz[0, 2] == matriz[1, 1] && matriz[0, 2] == matriz[2, 0])
            {
                hayGanador = true;
            }

            if(hayGanador)
            {
                MessageBox.Show("Ganador " + ganador, "Felicitaciones!");
                for (int i = 1; i <= 9; i++)
                {
                    string nombreBoton = $"button{i}";
                    Control[] controlesEncontrados = this.Controls.Find(nombreBoton, true);

                    if (controlesEncontrados.Length > 0 && controlesEncontrados[0] is Button boton)
                    {
                        boton.Enabled = false;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jugar(button1);
            button1.Enabled = false;
            matriz[0, 0] = turnoEquis ? "X" : "O";
            calcularGanador();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jugar(button2);
            button2.Enabled = false;
            matriz[0, 1] = turnoEquis ? "X" : "O";
            calcularGanador();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            jugar(button3);
            button3.Enabled = false;
            matriz[0, 2] = turnoEquis ? "X" : "O";
            calcularGanador();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            jugar(button4);
            button4.Enabled = false;
            matriz[1, 0] = turnoEquis ? "X" : "O";
            calcularGanador();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            jugar(button5);
            button5.Enabled = false;
            matriz[1, 1] = turnoEquis ? "X" : "O";
            calcularGanador();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            jugar(button6);
            button6.Enabled = false;
            matriz[1, 2] = turnoEquis ? "X" : "O";
            calcularGanador();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            jugar(button7);
            button7.Enabled = false;
            matriz[2, 0] = turnoEquis ? "X" : "O";
            calcularGanador();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            jugar(button8);
            button8.Enabled = false;
            matriz[2, 1] = turnoEquis ? "X" : "O";
            calcularGanador();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            jugar(button9);
            button9.Enabled = false;
            matriz[2, 2] = turnoEquis ? "X" : "O";
            calcularGanador();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            turnoEquis = true;
            label1.Text = "Turno de X";

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = string.Format("{0},{1}", i, j);
                }
            }

            for (int i = 1; i <= 9; i++)
            {
                string nombreBoton = $"button{i}";
                Control[] controlesEncontrados = this.Controls.Find(nombreBoton, true);

                if (controlesEncontrados.Length > 0 && controlesEncontrados[0] is Button boton)
                {
                    boton.Text = ".";
                    boton.BackColor = Color.Gray;
                    boton.Enabled = true;
                }
            }
        }
    }
}
