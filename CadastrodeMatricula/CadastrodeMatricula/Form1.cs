using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrodeMatricula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void HabilitarBotao()
        {
            btnDeletar.Enabled = true;
            btnCadastrar.Enabled = true;
        }


        private void LimparCampos()
        {
            txtnumero1.Text = "";
            txtnumero2.Text = "";
            txtcpf.Text = "";
            txtdata.Text = "";
            txtemail.Text = "";
            txtnome.Text = "";
            txtendereço.Text = "";
            txtestcivil.Text = "";
            txtsexo.Text = "";

        }

        private void DesabilitarCampos()
        {
            txtnome.Enabled = false;
            txtnumero1.Enabled = false;
            txtemail.Enabled = false;
            txtnumero2.Enabled = false;
            txtcpf.Enabled = false;
            txtdata.Enabled = false;
            txtendereço.Enabled = false;
            txtestcivil.Enabled = false;
            txtsexo.Enabled= false;
        }

        private void HabilitarCampos()
        {
            txtnome.Enabled = true;
            txtnumero1.Enabled = true;
            txtemail.Enabled = true;
            txtnumero2.Enabled = true;
            txtcpf.Enabled = true;
            txtdata.Enabled = true;
            txtendereço.Enabled = true;
            txtestcivil.Enabled = true;
            txtsexo.Enabled = true;


        }

        private void DesabilitarBotao()
        {
            //btnnovo.Enabled = false;
            btnCadastrar.Enabled = false;
            btnDeletar.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            LimparCampos();
            HabilitarBotao();
            btnNovo.Enabled = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimparCampos();
            DesabilitarBotao();
            btnNovo.Enabled = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
            btnDeletar.Enabled = false;
            btnNovo.Enabled = true;
            LimparCampos() ;
            DesabilitarBotao();
            DesabilitarCampos();
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
