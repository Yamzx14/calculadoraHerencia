using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadoraHerencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            Sumar suma= new Sumar();
            txtxresultado.Text=suma.operar(double.Parse(txtV1.Text),double.Parse(txtV2.Text)).ToString();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            Restar resta = new Restar();
            txtxresultado.Text = resta.operar(double.Parse(txtV1.Text), double.Parse(txtV2.Text)).ToString();
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            Multiplicar multiplicar = new Multiplicar();
            txtxresultado.Text = multiplicar.operar(double.Parse(txtV1.Text), double.Parse(txtV2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtV1.Clear();
            txtV2.Clear();
            txtxresultado.Clear();
        }
    }
}
