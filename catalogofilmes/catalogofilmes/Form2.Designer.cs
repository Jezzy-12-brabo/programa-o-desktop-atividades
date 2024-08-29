namespace catalogofilmes
{
    partial class frmpagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmpagamento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btnpagamento = new System.Windows.Forms.Button();
            this.txtPix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcartao = new System.Windows.Forms.TextBox();
            this.txtvt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btndeletar = new System.Windows.Forms.Button();
            this.txtquant = new System.Windows.Forms.TextBox();
            this.ll = new System.Windows.Forms.Label();
            this.txtformapag = new System.Windows.Forms.TextBox();
            this.Btngravar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 85);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 25);
            this.button1.TabIndex = 37;
            this.button1.Text = "voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(363, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "PAGAMENTO";
            // 
            // Btnpagamento
            // 
            this.Btnpagamento.Location = new System.Drawing.Point(354, 400);
            this.Btnpagamento.Name = "Btnpagamento";
            this.Btnpagamento.Size = new System.Drawing.Size(109, 24);
            this.Btnpagamento.TabIndex = 9;
            this.Btnpagamento.Text = "Efetuar Pagamento";
            this.Btnpagamento.UseVisualStyleBackColor = true;
            this.Btnpagamento.Click += new System.EventHandler(this.Btnpagamento_Click);
            // 
            // txtPix
            // 
            this.txtPix.Location = new System.Drawing.Point(24, 217);
            this.txtPix.Name = "txtPix";
            this.txtPix.Size = new System.Drawing.Size(100, 20);
            this.txtPix.TabIndex = 10;
            this.txtPix.TextChanged += new System.EventHandler(this.txtPix_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Escolha sua forma de pagamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Digite seu Pix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Senha";
            // 
            // txtsenha
            // 
            this.txtsenha.Location = new System.Drawing.Point(24, 254);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(100, 20);
            this.txtsenha.TabIndex = 15;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Digite seu cartão";
            // 
            // txtcartao
            // 
            this.txtcartao.Location = new System.Drawing.Point(24, 178);
            this.txtcartao.Name = "txtcartao";
            this.txtcartao.Size = new System.Drawing.Size(100, 20);
            this.txtcartao.TabIndex = 16;
            this.txtcartao.TextChanged += new System.EventHandler(this.txtcartao_TextChanged);
            // 
            // txtvt
            // 
            this.txtvt.Location = new System.Drawing.Point(24, 340);
            this.txtvt.Name = "txtvt";
            this.txtvt.Size = new System.Drawing.Size(100, 20);
            this.txtvt.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor Total";
            // 
            // Btndeletar
            // 
            this.Btndeletar.Location = new System.Drawing.Point(504, 400);
            this.Btndeletar.Name = "Btndeletar";
            this.Btndeletar.Size = new System.Drawing.Size(59, 24);
            this.Btndeletar.TabIndex = 20;
            this.Btndeletar.Text = "Deletar";
            this.Btndeletar.UseVisualStyleBackColor = true;
            this.Btndeletar.Click += new System.EventHandler(this.Btndeletar_Click);
            // 
            // txtquant
            // 
            this.txtquant.Location = new System.Drawing.Point(24, 301);
            this.txtquant.Name = "txtquant";
            this.txtquant.Size = new System.Drawing.Size(100, 20);
            this.txtquant.TabIndex = 22;
            // 
            // ll
            // 
            this.ll.AutoSize = true;
            this.ll.Location = new System.Drawing.Point(21, 285);
            this.ll.Name = "ll";
            this.ll.Size = new System.Drawing.Size(104, 13);
            this.ll.TabIndex = 21;
            this.ll.Text = "quantidade produtos";
            // 
            // txtformapag
            // 
            this.txtformapag.Location = new System.Drawing.Point(24, 135);
            this.txtformapag.Name = "txtformapag";
            this.txtformapag.Size = new System.Drawing.Size(100, 20);
            this.txtformapag.TabIndex = 23;
            // 
            // Btngravar
            // 
            this.Btngravar.Location = new System.Drawing.Point(130, 132);
            this.Btngravar.Name = "Btngravar";
            this.Btngravar.Size = new System.Drawing.Size(51, 24);
            this.Btngravar.TabIndex = 24;
            this.Btngravar.Text = "gravar";
            this.Btngravar.UseVisualStyleBackColor = true;
            this.Btngravar.Click += new System.EventHandler(this.Btngravar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(2, 425);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(32, 22);
            this.button3.TabIndex = 36;
            this.button3.Text = "sair";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(600, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 362);
            this.panel2.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(13, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Carrrinho de Compras";
            // 
            // frmpagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Btngravar);
            this.Controls.Add(this.txtformapag);
            this.Controls.Add(this.txtquant);
            this.Controls.Add(this.ll);
            this.Controls.Add(this.Btndeletar);
            this.Controls.Add(this.txtvt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtcartao);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPix);
            this.Controls.Add(this.Btnpagamento);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmpagamento";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.frmpagamento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btnpagamento;
        private System.Windows.Forms.TextBox txtPix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcartao;
        private System.Windows.Forms.TextBox txtvt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btndeletar;
        private System.Windows.Forms.TextBox txtquant;
        private System.Windows.Forms.Label ll;
        private System.Windows.Forms.TextBox txtformapag;
        private System.Windows.Forms.Button Btngravar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
    }
}