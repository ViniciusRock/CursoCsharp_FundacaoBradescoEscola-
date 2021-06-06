using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtUsuario.Text;
            senha = txtSenha.Text;
            if(usuario == "Admin" && senha == "Admin")
            {
                Form2 abreform2 = new Form2();
                abreform2.Show();
                this.Visible = false;
            }
            else if(usuario == "Lara" && senha == "Lara")
            {
                Form3 abreform3 = new Form3();
                abreform3.Show();
                this.Visible = false;

            }
        }
    }
}
