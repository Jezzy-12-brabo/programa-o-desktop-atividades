using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void BTnacesso_Click(object sender, EventArgs e)
        {
            string user = "Jesse";
            string password = "12345";

            if (Txtusuario.Text == user & Txtsenha.Text == password)
            {
                MessageBox.Show("Acesso Liberado!");
                frmprincipal FrmMain = new frmprincipal();
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário/Senha Incorreta!");
            }
        }

        private void Txtusuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
