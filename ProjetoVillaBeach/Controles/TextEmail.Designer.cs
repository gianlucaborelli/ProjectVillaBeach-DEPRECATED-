namespace ProjetoVillaBeach.Controles
{
    partial class TextEmail
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlValido = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(3, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(358, 16);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.Text = "E-Mail";
            this.txtEmail.Enter += new System.EventHandler(this.Txt_Enter);
            this.txtEmail.Leave += new System.EventHandler(this.Txt_Leave);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Validating);
            // 
            // pnlValido
            // 
            this.pnlValido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlValido.Location = new System.Drawing.Point(0, 30);
            this.pnlValido.Name = "pnlValido";
            this.pnlValido.Size = new System.Drawing.Size(367, 2);
            this.pnlValido.TabIndex = 1;
            // 
            // TextEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.pnlValido);
            this.Controls.Add(this.txtEmail);
            this.Name = "TextEmail";
            this.Size = new System.Drawing.Size(367, 32);
            this.BackColorChanged += new System.EventHandler(this.Control_BackColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlValido;
    }
}
