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
    public partial class frmcliente : Form
    {
        public frmcliente()
        {
            InitializeComponent();
        }


        private void frmcliente_Load(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            frmcadastrocliente FrmMain = new frmcadastrocliente();
            FrmMain.Show();
            this.Hide();
        }

        private void pequisaclientetext_TextChanged(object sender, EventArgs e)
        {
            string user = "Jesse";
            string email = "jessebrabo57@gmail.com";

            if (txtemailpesquisa.Text == user & txtemailpesquisa.Text == email)
            {
                MessageBox.Show("Usuário cadastrado!");
                frmcadastrocliente FrmMain = new frmcadastrocliente();
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário não cadastrado");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
