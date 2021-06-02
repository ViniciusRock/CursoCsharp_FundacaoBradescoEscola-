using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_FOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            for (int contador = 0; contador < 50; contador++)
            {
                MessageBox.Show("O valor de contador é: " + contador);
                //Console.WriteLine("O valor do contador é: " + contador);
                //WriteLine - é o comando que pula a linha
                //O Ctrl + Alt + O mostra a janela do console para saber
                //se ocorreram erros e se o código acima funcionou.
                //Verifica detalhes do código para ver ocorrência de erros.
            }
        }
    }
}
