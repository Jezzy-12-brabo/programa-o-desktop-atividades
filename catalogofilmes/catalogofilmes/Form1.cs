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
    public partial class frmcatalogo : Form
    {
        public frmcatalogo()
        {
            InitializeComponent();
        }

        public void Btnadd1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionadado ao Carrinho!");


        }

        private void Btnadd2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionadado ao Carrinho!");

        }

        public void Btnadd3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionadado ao Carrinho!");

        }

        public void Btnadd4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Adicionadado ao Carrinho!");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        } 
       
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmpagamento Frmmain = new frmpagamento();
            Frmmain.Show();
            this.Hide();
        }
    }
}
