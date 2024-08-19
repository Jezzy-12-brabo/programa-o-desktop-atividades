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
    }
}
