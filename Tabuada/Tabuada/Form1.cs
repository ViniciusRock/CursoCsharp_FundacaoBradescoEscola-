using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int numero, resultado, i;
            i = 0;
            numero = int.Parse(txtNumero.Text);
            while (i <= 10)
            {
                resultado = i * numero;
                lstTabuada.Items.Add(String.Concat(numero, " * ", i, " = ", resultado));
                i = i + 1;
            }
            /* Declaração das variáveis do tipo inteiro
             * Conversão para int
             * Condição, enquanto o i for menor ou igual a 10
             * variável resultado realiza o cálculo de i
             * multiplicado pelo número digitado.
             * ListBox adiciona o item e concatena (numero * i = resultado)
             * incremento
             */
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero.Text = " ";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
