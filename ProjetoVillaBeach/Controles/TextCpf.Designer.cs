namespace ProjetoVillaBeach.Controles
{
    partial class TextCpf
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
            this.pnlValido = new System.Windows.Forms.Panel();
            this.txtCpf = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pnlValido
            // 
            this.pnlValido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlValido.Location = new System.Drawing.Point(0, 32);
            this.pnlValido.Name = "pnlValido";
            this.pnlValido.Size = new System.Drawing.Size(326, 2);
            this.pnlValido.TabIndex = 0;
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCpf.ForeColor = System.Drawing.Color.Gray;
            this.txtCpf.Location = new System.Drawing.Point(4, 3);
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(317, 16);
            this.txtCpf.TabIndex = 1;
            this.txtCpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpf_KeyPress);
            this.txtCpf.Leave += new System.EventHandler(this.TextCpf_Leave);
            // 
            // TextCpf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.pnlValido);
            this.Name = "TextCpf";
            this.Size = new System.Drawing.Size(326, 34);
            this.BackColorChanged += new System.EventHandler(this.TextCpf_BackColorChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlValido;
        private System.Windows.Forms.TextBox txtCpf;
    }
}
