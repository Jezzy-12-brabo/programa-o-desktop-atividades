using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catalogofilmes
{
    public partial class frmpagamento : Form
    {
        public frmpagamento()
        {
            InitializeComponent();
        }
        private void HabilitarBotao()
        {
            Btnpagamento.Enabled = true;
            Btndeletar.Enabled = true;
        }


        private void LimparCampos()
        {
            //txtformapag.Text = "";
            txtPix.Text = "";
            txtcartao.Text = "";
            txtsenha.Text = "";
            txtvt.Text = "";
            txtquant.Text = "";
            txtsenha.Text = "";
        }

        private void Limparpix()
        {

            txtformapag.Text = "";
            txtPix.Text = "";
        }

        private void Limparcatao()
        {

            txtformapag.Text = "";
            txtcartao.Text = "";
            
        }

        private void Desabilitarpix()
        {
            txtformapag.Enabled = false;
            txtPix.Enabled = false;
        }
        private void Desabilitarcatao()
        {
            txtformapag.Enabled = false;
            txtcartao.Enabled = false;
        }
        private void DesabilitarCampos()
        {

            //txtformapag.Enabled = false;
            txtPix.Enabled = false;
            txtcartao.Enabled = false;
            txtsenha.Enabled = false;
            txtvt.Enabled = false;
            txtPix.Enabled = false;
            txtquant.Enabled = false;


        }

        private void HabilitarCampos()
        {
            txtformapag.Enabled = true;
            txtPix.Enabled = true;
            txtcartao.Enabled = true;
            txtsenha.Enabled = true;
            txtvt.Enabled = true;
            txtsenha.Enabled = true;
            txtquant.Enabled = true;

        }

        private void DesabilitarBotao()
        {
            Btnpagamento.Enabled = false;
            Btndeletar.Enabled = false;
        }
        private void txtformapag_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Btndeletar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarBotao();
            DesabilitarCampos();
        }

        private void Btnpagamento_Click(object sender, EventArgs e)
        {
            LimparCampos();
            DesabilitarCampos();
            MessageBox.Show("Transação Efetuada");
        }
        private void txtcartao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPix_TextChanged(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }

        private void txtsenha_TextChanged(object sender, EventArgs e)
        {
            DesabilitarCampos();
        }
        private void Btngravar_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
            if (txtformapag.Text == "pix")
            {
               Limparcatao();
               Desabilitarcatao();

            }
            else if (txtformapag.Text == "cartao")
            {
                Limparpix();
                Desabilitarpix();

            }
            else
            {
                LimparCampos();
                DesabilitarCampos();
                MessageBox.Show("Forma de pagamento não cadastrado.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmcatalogo Frmmain = new frmcatalogo();
            Frmmain.Show();
            this.Close();
        }

        private void frmpagamento_Load(object sender, EventArgs e)
        {
            DesabilitarCampos();
            LimparCampos();
        }
    }
}
