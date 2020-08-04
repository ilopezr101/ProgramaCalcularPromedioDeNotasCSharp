using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double nota1, nota2, nota3, promedio;

            nota1 = double.Parse(txtnota1.Text);
            nota2 = double.Parse(txtnota2.Text);
            nota3 = double.Parse(txtnota3.Text);

            promedio = (nota1 + nota2 + nota3) /3;

            lblresultado.Text = Convert.ToString(promedio);

            lblpromedio.Visible = true;


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtnota1.Text = String.Empty;
            txtnota2.Text = String.Empty;
            txtnota3.Text = String.Empty;
            lblresultado.Text = String.Empty;
            lblpromedio.Visible = false;
            txtnota1.Focus();

        }
    }
}
