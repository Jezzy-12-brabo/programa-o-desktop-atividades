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
    public partial class frmcadastrocliente : Form
    {
        public frmcadastrocliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void HabilitarBotao()
        {
            btnnovo.Enabled = true;
            btndeletar.Enabled = true;
            btndeletar.Enabled = true;
        }


        private void LimparCampos()
        {
            txtcelular1.Text = "";
            txtcelular2.Text = "";
            txtcidade.Text = "";
            txtcpf.Text = "";
            txtdata.Text = "";
            txtemail.Text = "";
            txtid.Text = "";
            txtnome.Text = "";
        }

        private void DesabilitarCampos()
        {
            txtid.Enabled = false;
            txtnome.Enabled = false;
            txtcelular1.Enabled = false;
            txtemail.Enabled = false;
            txtcelular2.Enabled = false;
            txtcidade.Enabled = false;
            txtcpf.Enabled = false;
            txtdata.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txtid.Enabled = true;
            txtnome.Enabled = true;
            txtcelular1.Enabled = true;
            txtemail.Enabled = true;
            txtcelular2.Enabled = true;
            txtcidade.Enabled = true;
            txtcpf.Enabled = true; 
            txtdata.Enabled = true; 
            

        }

        private void DesabilitarBotao()
        {
            btnnovo.Enabled = false;
            btncadastrar.Enabled = false;
            btndeletar.Enabled = false;
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimparCampos();
            DesabilitarBotao();
            btncadastrar.Enabled = true;
            //con.AbrirConexão();

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            txtid.Focus();
            HabilitarBotao();
            btnnovo.Enabled = false;
        }

        private void btndeletar_Click(object sender, EventArgs e)
        {

        }
    }
}
