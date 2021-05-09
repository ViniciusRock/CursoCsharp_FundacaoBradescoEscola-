using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcelas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double valor, parcela, resultado;

            valor = Convert.ToDouble(txtValor.Text);
            parcela = Convert.ToDouble(txtParcela.Text);

            resultado = valor / parcela;

            txtResultado.Text = resultado.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
