namespace WindowsFormsApp1
{
    partial class frmcliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcliente));
            this.cadastrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpequisacliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtemailpesquisa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastrar
            // 
            this.cadastrar.Location = new System.Drawing.Point(683, 12);
            this.cadastrar.Name = "cadastrar";
            this.cadastrar.Size = new System.Drawing.Size(75, 23);
            this.cadastrar.TabIndex = 0;
            this.cadastrar.Text = "cadastrar";
            this.cadastrar.UseVisualStyleBackColor = true;
            this.cadastrar.Click += new System.EventHandler(this.cadastrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(90, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "pesquisar cliente";
            this.label1.UseCompatibleTextRendering = true;
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpequisacliente
            // 
            this.txtpequisacliente.Location = new System.Drawing.Point(90, 68);
            this.txtpequisacliente.Name = "txtpequisacliente";
            this.txtpequisacliente.Size = new System.Drawing.Size(100, 20);
            this.txtpequisacliente.TabIndex = 2;
            this.txtpequisacliente.TextChanged += new System.EventHandler(this.pequisaclientetext_TextChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(115, 133);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtemailpesquisa
            // 
            this.txtemailpesquisa.Location = new System.Drawing.Point(90, 107);
            this.txtemailpesquisa.Name = "txtemailpesquisa";
            this.txtemailpesquisa.Size = new System.Drawing.Size(100, 20);
            this.txtemailpesquisa.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(87, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "pesquisar email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtpequisacliente);
            this.panel1.Controls.Add(this.txtemailpesquisa);
            this.panel1.Controls.Add(this.button2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(279, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 208);
            this.panel1.TabIndex = 7;
            // 
            // frmcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cadastrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcliente";
            this.Text = "cliente";
            this.Load += new System.EventHandler(this.frmcliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpequisacliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtemailpesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}