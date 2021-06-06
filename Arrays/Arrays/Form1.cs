using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 512;
            vetor[2] = 001;
            vetor[3] = -570;
            int valor = vetor[1];
            //A linha de baixo faz um
            //sorteio de array
            //(um sort e randomiza o que será guardado dentro do vetor "vetor")
            System.Array.Sort(vetor);
            for(int index = 0; index < 4; index++)
            {
                MessageBox.Show(vetor[index].ToString(),"Array",MessageBoxButtons.OK);
            }
            /*Declarar e instanciar o vetor
              * Atribuição de valores de acordo com cada índice
              * Declara variável "valor" para acessar o vetor
              * System.Array.Sort - Esta classe ordena o vetor
              * Comando for - Percorre o vetor em cada índice.
              * Condição - Para índice menor que 4  (de 0 a 3), ele exibe uma msg
                com o vetor na MessageBox.
            */
        }
    }
}
