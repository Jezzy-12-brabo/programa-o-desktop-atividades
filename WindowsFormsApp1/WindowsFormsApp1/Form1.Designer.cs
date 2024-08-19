namespace WindowsFormsApp1
{
    partial class frmlogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmlogin));
            this.noome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtusuario = new System.Windows.Forms.TextBox();
            this.Txtsenha = new System.Windows.Forms.TextBox();
            this.BTnacesso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // noome
            // 
            this.noome.AutoSize = true;
            this.noome.Location = new System.Drawing.Point(375, 152);
            this.noome.Name = "noome";
            this.noome.Size = new System.Drawing.Size(33, 13);
            this.noome.TabIndex = 0;
            this.noome.Text = "nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txtusuario
            // 
            this.Txtusuario.Location = new System.Drawing.Point(440, 152);
            this.Txtusuario.Name = "Txtusuario";
            this.Txtusuario.Size = new System.Drawing.Size(100, 20);
            this.Txtusuario.TabIndex = 2;
            // 
            // Txtsenha
            // 
            this.Txtsenha.Location = new System.Drawing.Point(440, 178);
            this.Txtsenha.Name = "Txtsenha";
            this.Txtsenha.Size = new System.Drawing.Size(100, 20);
            this.Txtsenha.TabIndex = 3;
            // 
            // BTnacesso
            // 
            this.BTnacesso.Location = new System.Drawing.Point(440, 229);
            this.BTnacesso.Name = "BTnacesso";
            this.BTnacesso.Size = new System.Drawing.Size(75, 23);
            this.BTnacesso.TabIndex = 4;
            this.BTnacesso.Text = "entrar";
            this.BTnacesso.UseVisualStyleBackColor = true;
            this.BTnacesso.Click += new System.EventHandler(this.BTnacesso_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.BTnacesso);
            this.Controls.Add(this.Txtsenha);
            this.Controls.Add(this.Txtusuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.noome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmlogin";
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label noome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtusuario;
        private System.Windows.Forms.TextBox Txtsenha;
        private System.Windows.Forms.Button BTnacesso;
    }
}

