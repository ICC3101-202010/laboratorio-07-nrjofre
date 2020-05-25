using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double resultado;
        double? ans = null;
        string signo;


        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "0";
        }

        private void coma_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + ",";
        }

        private void bottonIgual_Click(object sender, EventArgs e)
        {
            bool salir = true;
            try
            {
                num2 = double.Parse(Pantalla.Text);
            }
            catch
            {
                Pantalla.Text = "Syntax Error";
                salir = false;
            }


            if (salir)
            {   switch (signo)
                {
                    case "+":
                        resultado = num1 + num2;
                        ans = resultado;
                        Pantalla.Text = resultado.ToString();
                        break;

                    case "-":
                        resultado = num1 - num2;
                        ans = resultado;
                        Pantalla.Text = resultado.ToString();
                        break;

                    case "/":
                        resultado = num1 / num2;

                        if (Double.IsPositiveInfinity(resultado) || Double.IsNegativeInfinity(resultado))
                        {
                            Pantalla.Text = "Math Error";
                            break;
                        }
                        ans = resultado;

                        Pantalla.Text = resultado.ToString();
                        break;

                    case "x":
                        resultado = num1 * num2;
                        ans = resultado;
                        Pantalla.Text = resultado.ToString();
                        break;
                }

            }
        }

        private void buttonANS_Click(object sender, EventArgs e)
        {
            if (ans != null & Pantalla.Text.Length == 0)//si ans tiene un valor
            {
                Pantalla.Text = ans.ToString(); ;
            }
            else if (ans != null & Pantalla.Text.Length != 0)
            {
                Pantalla.Clear();
                Pantalla.Text = Pantalla.Text + ans.ToString(); ;
            }
            else
            {

            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Pantalla.Text = Pantalla.Text + "9";
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {

            if (Pantalla.Text.Length != 0 )
            {
                bool salir = true;
                try
                {
                    num1 = double.Parse(Pantalla.Text);
                }
                catch
                {
                    Pantalla.Text = "Syntax Error";
                    salir = false;
                }
                
                if (salir)
                {
                    num1 = double.Parse(Pantalla.Text);
                    signo = "x";
                    Pantalla.Clear();
                }   
            }        
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                bool salir = true;
                try
                {
                    num1 = double.Parse(Pantalla.Text);
                }
                catch
                {
                    Pantalla.Text = "Syntax Error";
                    salir = false;
                }

                if (salir)
                {
                    num1 = double.Parse(Pantalla.Text);
                    signo = "/";
                    Pantalla.Clear();
                }
            }
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                bool salir = true;
                try
                {
                    num1 = double.Parse(Pantalla.Text);
                }
                catch
                {
                    Pantalla.Text = "Syntax Error";
                    salir = false;
                }

                if (salir)
                {
                    num1 = double.Parse(Pantalla.Text);
                    signo = "-";
                    Pantalla.Clear();
                }
            }
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                bool salir = true;
                try
                {
                    num1 = double.Parse(Pantalla.Text);
                }
                catch
                {
                    Pantalla.Text = "Syntax Error";
                    salir = false;
                }

                if (salir)
                {
                    num1 = double.Parse(Pantalla.Text);
                    signo = "+";
                    Pantalla.Clear();
                }
            }
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void buttonDEL_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length != 0)
            {
                Pantalla.Text = Pantalla.Text.Remove(Pantalla.Text.Length - 1);
            }
        }
    }
}
