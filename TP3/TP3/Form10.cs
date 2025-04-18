using System;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int temp1 = Convert.ToInt32(textBox1.Text);
                string escala1 = comboBox1.Text;
                string escala2 = comboBox2.Text;

                label3.Text = calcularConversion(temp1, string.Format("{0}-{1}", escala1, escala2));
            }
            catch (Exception)
            {
                limpiar();
            }
        }

        private String calcularConversion(int temp1, string escala)
        {
            switch(escala)
            {
                case "Celsius-Celsius":
                    return temp1 + "°C";
                case "Celsius-Fahrenheit":
                    double auxCF = (temp1 * 9 / 5) + 32;
                    return auxCF + "°F";
                case "Celsius-Kelvin":
                    double auxCK = (double) temp1 + 273.15;
                    return auxCK + "°K";
                case "Celsius-Rankine":
                    double auxCR = temp1 * 9 / 5 + 491.67;
                    return auxCR + "°R";
                case "Fahrenheit-Celsius":
                    double auxFC = (temp1 - 32) * 5.0 / 9;
                    return auxFC + "°C";
                case "Fahrenheit-Fahrenheit":
                    return temp1 + "°F";
                case "Fahrenheit-Kelvin":
                    double auxFK = (temp1 - 32) * 5 / 9 + 273.15;
                    return auxFK +"°K";
                case "Fahrenheit-Rankine":
                    return (temp1 + 459.67) + "°R";
                case "Kelvin-Celsius":
                    return (temp1 - 273.15) + "°C";
                case "Kelvin-Fahrenheit":
                    double auxKF = (temp1 - 273.15) * 9 / 5 + 32;
                    return auxKF + "°F";
                case "Kelvin-Kelvin":
                    return temp1 + "°K";
                case "Kelvin-Rankine":
                    return ((temp1 * 1.8) * 5.0 / 9) + "°C";
                case "Rankine-Celsius":
                    return (temp1 - 459.67) + "°F";
                case "Rankine-Fahrenheit":
                     return (temp1 - 459.67) + "°F";
                case "Rankine-Kelvin":
                    return (temp1 * 5.0 / 9) + "°K";
                case "Rankine-Rankine":
                    return temp1 + "°R";
                default:
                    return "";
            }
        }
    }
}
