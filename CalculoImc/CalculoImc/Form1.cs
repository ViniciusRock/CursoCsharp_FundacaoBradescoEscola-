using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoImc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            /*
             Declaração de variáveis
            variável recebe o conteúdo da textbox
             */
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            /*textbox recebe conteudo da variavel IMC =
             * resultado do cálculo
             * definição de utilização de 2 casas decimais */
            txtImc.Text = imc.ToString("0.00");
            /* Condições de acordo com os resultados dos cálculos
             * Serão exibidas mensagens,
             * configurações das MessageBox,("mensagem",título da mensagem,botões, ícone);
             * como são variáveis condicionais temos um encadeamento de ifs
             */
            if (imc < 18.49)
            {
                MessageBox.Show("SITUAÇÃO: Você está abaixo do Peso.", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc >= 18.5 || imc <= 24.99)
            {
                MessageBox.Show("SITUAÇÃO: Você está com o peso dentro da normalidade.", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc >= 25 || imc <= 29.99)
            {
                MessageBox.Show("SITUAÇÃO: Você está acima do peso.", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc >= 30 || imc <= 34.99)
            {
                MessageBox.Show("SITUAÇÃO: Atenção, você está com Obesidade Grau I.", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (imc >= 35 || imc <= 39.99)
            {
                MessageBox.Show("SITUAÇÃO: Atenção, você está com Obesidade Grau II(severa).", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (imc > 40)
            {
                MessageBox.Show("SITUAÇÃO: Atenção, você está com Obesidade Grau II(severa).", "Cálculo de IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            txtPeso.Text = "";
            txtAltura.Text = "";
            txtImc.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
