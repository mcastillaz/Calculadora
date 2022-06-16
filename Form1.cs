using AppCalculator.Clases;

namespace AppCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string operador = "";
        float resultado = 0, numero = 0;

        Formulario formulario = new Formulario();
        Operaciones operaciones = new Operaciones();

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text == "" || textBoxScreen.Text == "0")
            {
                textBoxScreen.Text = "1";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text + "1";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text == "" || textBoxScreen.Text == "0")
            {
                textBoxScreen.Text = "2";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text + "2";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text == "" || textBoxScreen.Text == "0")
            {
                textBoxScreen.Text = "3";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text + "3";
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text == "" || textBoxScreen.Text == "0")
            {
                textBoxScreen.Text = "4";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text + "4";
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text == "" || textBoxScreen.Text == "0")
            {
                textBoxScreen.Text = "5";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text + "5";
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text == "" || textBoxScreen.Text == "0")
            {
                textBoxScreen.Text = "6";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text + "6";
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text == "" || textBoxScreen.Text == "0")
            {
                textBoxScreen.Text = "7";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text + "7";
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text == "" || textBoxScreen.Text == "0")
            {
                textBoxScreen.Text = "8";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text + "8";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text == "" || textBoxScreen.Text == "0")
            {
                textBoxScreen.Text = "9";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text + "9";
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text == "" || textBoxScreen.Text == "0")
            {
                textBoxScreen.Text = "0";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text + "0";
            }
        }
        private void buttonPunto_Click(object sender, EventArgs e)
        {
            if (textBoxScreen.Text == "" || textBoxScreen.Text == "0")
            {
                textBoxScreen.Text = ",";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text + ",";
            }

        }
        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            labelScreen.Text = String.Empty;
            textBoxScreen.Text = String.Empty;
            textBoxScreen.Text = "0";
            resultado = 0;
        }
        private void buttonBorrarDigito_Click(object sender, EventArgs e)
        {
            //SendKeys.Send("{BACKSPACE}");
            if (textBoxScreen.Text.Length == 1)
            {
                textBoxScreen.Text = "";
            }
            else
            {
                textBoxScreen.Text = textBoxScreen.Text.Substring(0, textBoxScreen.TextLength - 1);
            }
        }
        private void buttonResultado_Click(object sender, EventArgs e)
        {
            labelScreen.Text = labelScreen.Text.ToString() + "" + textBoxScreen.Text.ToString()+ "=";
            Calcular();
            //textBoxScreen.Text = "";
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            //Operacion de suma
            operador = "+";
            numero = float.Parse(textBoxScreen.Text);
            textBoxScreen.Clear();
            labelScreen.Text = String.Empty;
            labelScreen.Text = numero.ToString() + "+";

        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            //Operacion de Multiplicacion
            operador = "*";
            numero = float.Parse(textBoxScreen.Text);
            textBoxScreen.Clear();
            labelScreen.Text = String.Empty;
            labelScreen.Text = numero.ToString() + "*";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            //Operacion de Division
            operador = "/";
            numero = float.Parse(textBoxScreen.Text);
            textBoxScreen.Clear();
            labelScreen.Text = String.Empty;
            labelScreen.Text = numero.ToString() + "/";
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            //Operacion de resta 
            operador = "-";
            numero = float.Parse(textBoxScreen.Text);
            textBoxScreen.Clear();
            labelScreen.Text = String.Empty;
            labelScreen.Text = numero.ToString() + "-";
        }

        private void textBoxScreen_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEcuacionSimple_Click(object sender, EventArgs e)
        {
            formulario.ShowDialog();
        }

        public void Calcular()
        {
            switch (operador)
            {

                case "+":
                    resultado = operaciones.Suma(numero, float.Parse(textBoxScreen.Text));
                    textBoxScreen.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = operaciones.Resta(numero, float.Parse(textBoxScreen.Text));
                    textBoxScreen.Text = resultado.ToString();
                    break;

                case "*":
                    resultado = operaciones.Multiplicacion(numero, float.Parse(textBoxScreen.Text));
                    textBoxScreen.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = operaciones.Division(numero, float.Parse(textBoxScreen.Text));
                    textBoxScreen.Text = resultado.ToString();
                    break;

                default:
                    break;
            }
        }
    }
}