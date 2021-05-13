using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicao_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtverifica_Click(object sender, EventArgs e)
        {
            int idade;
            idade = Convert.ToInt32(txtIdade.Text);
            if (idade >= 18)
            {
                MessageBox.Show("Maior de Idade", "Idade verificada!", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                MessageBox.Show("Menor de Idade", "Idade verificada!", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            
        }
    }
}
