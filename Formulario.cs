using AppCalculator.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppCalculator
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        Operaciones operaciones = new Operaciones();

        double a = 0, b = 0, c = 0, x = 0;
        
        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            validarCalculo();
        }

        public void validarCalculo()
        {
                a = double.Parse(textBoxValorA.Text);
                b = double.Parse(textBoxValorB.Text);
                c = double.Parse(textBoxValorC.Text);
                x = operaciones.ReglaSimple(a, b, c);
                textBoxValorX.Text = x.ToString();
        }
    }
}
