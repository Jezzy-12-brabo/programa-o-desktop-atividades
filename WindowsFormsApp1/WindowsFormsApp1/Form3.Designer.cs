namespace WindowsFormsApp1
{
    partial class frmcadastrocliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcidade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.btndeletar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.txtcelular2 = new System.Windows.Forms.MaskedTextBox();
            this.txtcelular1 = new System.Windows.Forms.MaskedTextBox();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.txtcpf = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 444);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BurlyWood;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(308, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "id cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BurlyWood;
            this.label3.Location = new System.Drawing.Point(308, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "nome cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BurlyWood;
            this.label4.Location = new System.Drawing.Point(308, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "e-mail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BurlyWood;
            this.label5.Location = new System.Drawing.Point(308, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "cpf";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(469, 36);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 5;
            this.txtid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(469, 113);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 20);
            this.txtemail.TabIndex = 6;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(469, 61);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(100, 20);
            this.txtnome.TabIndex = 8;
            this.txtnome.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.BurlyWood;
            this.label6.Location = new System.Drawing.Point(308, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "celular 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.BurlyWood;
            this.label7.Location = new System.Drawing.Point(308, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "celular 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.BurlyWood;
            this.label8.Location = new System.Drawing.Point(310, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "cidade";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtcidade
            // 
            this.txtcidade.Location = new System.Drawing.Point(469, 188);
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.Size = new System.Drawing.Size(100, 20);
            this.txtcidade.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.BurlyWood;
            this.label9.Location = new System.Drawing.Point(310, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "data nascimento";
            // 
            // btncadastrar
            // 
            this.btncadastrar.Location = new System.Drawing.Point(311, 268);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(75, 23);
            this.btncadastrar.TabIndex = 17;
            this.btncadastrar.Text = "cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // btndeletar
            // 
            this.btndeletar.Location = new System.Drawing.Point(437, 268);
            this.btndeletar.Name = "btndeletar";
            this.btndeletar.Size = new System.Drawing.Size(75, 23);
            this.btndeletar.TabIndex = 18;
            this.btndeletar.Text = "deletar";
            this.btndeletar.UseVisualStyleBackColor = true;
            this.btndeletar.Click += new System.EventHandler(this.btndeletar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.Location = new System.Drawing.Point(550, 268);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(75, 23);
            this.btnnovo.TabIndex = 19;
            this.btnnovo.Text = "novo";
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // txtcelular2
            // 
            this.txtcelular2.Location = new System.Drawing.Point(469, 162);
            this.txtcelular2.Mask = "(99) 0000-0000";
            this.txtcelular2.Name = "txtcelular2";
            this.txtcelular2.Size = new System.Drawing.Size(100, 20);
            this.txtcelular2.TabIndex = 20;
            // 
            // txtcelular1
            // 
            this.txtcelular1.Location = new System.Drawing.Point(469, 136);
            this.txtcelular1.Mask = "(99) 0000-0000";
            this.txtcelular1.Name = "txtcelular1";
            this.txtcelular1.Size = new System.Drawing.Size(100, 20);
            this.txtcelular1.TabIndex = 21;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(469, 214);
            this.txtdata.Mask = "00/00/0000";
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(100, 20);
            this.txtdata.TabIndex = 22;
            this.txtdata.ValidatingType = typeof(System.DateTime);
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(469, 84);
            this.txtcpf.Mask = "000.000.000-00";
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 20);
            this.txtcpf.TabIndex = 23;
            this.txtcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // frmcadastrocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.txtcelular1);
            this.Controls.Add(this.txtcelular2);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btndeletar);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcidade);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmcadastrocliente";
            this.Text = "cadastro clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtcidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button btndeletar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.MaskedTextBox txtcelular2;
        private System.Windows.Forms.MaskedTextBox txtcelular1;
        private System.Windows.Forms.MaskedTextBox txtdata;
        private System.Windows.Forms.MaskedTextBox txtcpf;
    }
}