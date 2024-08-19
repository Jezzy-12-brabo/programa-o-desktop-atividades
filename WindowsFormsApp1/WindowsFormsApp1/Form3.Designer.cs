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
            this.idclientetext = new System.Windows.Forms.TextBox();
            this.emailtext = new System.Windows.Forms.TextBox();
            this.nomeclientetext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cidadetext = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.celular2text = new System.Windows.Forms.MaskedTextBox();
            this.celular1text = new System.Windows.Forms.MaskedTextBox();
            this.datadenasimentotext = new System.Windows.Forms.MaskedTextBox();
            this.cpftext = new System.Windows.Forms.MaskedTextBox();
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
            // idclientetext
            // 
            this.idclientetext.Location = new System.Drawing.Point(469, 36);
            this.idclientetext.Name = "idclientetext";
            this.idclientetext.Size = new System.Drawing.Size(100, 20);
            this.idclientetext.TabIndex = 5;
            this.idclientetext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // emailtext
            // 
            this.emailtext.Location = new System.Drawing.Point(469, 113);
            this.emailtext.Name = "emailtext";
            this.emailtext.Size = new System.Drawing.Size(100, 20);
            this.emailtext.TabIndex = 6;
            // 
            // nomeclientetext
            // 
            this.nomeclientetext.Location = new System.Drawing.Point(469, 61);
            this.nomeclientetext.Name = "nomeclientetext";
            this.nomeclientetext.Size = new System.Drawing.Size(100, 20);
            this.nomeclientetext.TabIndex = 8;
            this.nomeclientetext.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
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
            // cidadetext
            // 
            this.cidadetext.Location = new System.Drawing.Point(469, 188);
            this.cidadetext.Name = "cidadetext";
            this.cidadetext.Size = new System.Drawing.Size(100, 20);
            this.cidadetext.TabIndex = 14;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(437, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "deletar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(550, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "novo";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // celular2text
            // 
            this.celular2text.Location = new System.Drawing.Point(469, 162);
            this.celular2text.Mask = "(99) 0000-0000";
            this.celular2text.Name = "celular2text";
            this.celular2text.Size = new System.Drawing.Size(100, 20);
            this.celular2text.TabIndex = 20;
            // 
            // celular1text
            // 
            this.celular1text.Location = new System.Drawing.Point(469, 136);
            this.celular1text.Mask = "(99) 0000-0000";
            this.celular1text.Name = "celular1text";
            this.celular1text.Size = new System.Drawing.Size(100, 20);
            this.celular1text.TabIndex = 21;
            // 
            // datadenasimentotext
            // 
            this.datadenasimentotext.Location = new System.Drawing.Point(469, 214);
            this.datadenasimentotext.Mask = "00/00/0000";
            this.datadenasimentotext.Name = "datadenasimentotext";
            this.datadenasimentotext.Size = new System.Drawing.Size(100, 20);
            this.datadenasimentotext.TabIndex = 22;
            this.datadenasimentotext.ValidatingType = typeof(System.DateTime);
            // 
            // cpftext
            // 
            this.cpftext.Location = new System.Drawing.Point(469, 84);
            this.cpftext.Mask = "000.000.000-00";
            this.cpftext.Name = "cpftext";
            this.cpftext.Size = new System.Drawing.Size(100, 20);
            this.cpftext.TabIndex = 23;
            this.cpftext.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            // 
            // frmcadastrocliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cpftext);
            this.Controls.Add(this.datadenasimentotext);
            this.Controls.Add(this.celular1text);
            this.Controls.Add(this.celular2text);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cidadetext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nomeclientetext);
            this.Controls.Add(this.emailtext);
            this.Controls.Add(this.idclientetext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "frmcadastrocliente";
            this.Text = "clientes";
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
        private System.Windows.Forms.TextBox idclientetext;
        private System.Windows.Forms.TextBox emailtext;
        private System.Windows.Forms.TextBox nomeclientetext;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cidadetext;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox celular2text;
        private System.Windows.Forms.MaskedTextBox celular1text;
        private System.Windows.Forms.MaskedTextBox datadenasimentotext;
        private System.Windows.Forms.MaskedTextBox cpftext;
    }
}