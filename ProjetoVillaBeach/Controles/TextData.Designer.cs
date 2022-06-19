namespace ProjetoVillaBeach.Controles
{
    partial class TextData
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
            this.txtData = new System.Windows.Forms.TextBox();
            this.pnlValido = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtData.ForeColor = System.Drawing.Color.Gray;
            this.txtData.Location = new System.Drawing.Point(3, 3);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(275, 16);
            this.txtData.TabIndex = 0;
            this.txtData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Data_KeyPress);
            this.txtData.Leave += new System.EventHandler(this.Data_Leave);
            // 
            // pnlValido
            // 
            this.pnlValido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlValido.Location = new System.Drawing.Point(0, 24);
            this.pnlValido.Name = "pnlValido";
            this.pnlValido.Size = new System.Drawing.Size(281, 2);
            this.pnlValido.TabIndex = 1;
            // 
            // TextData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.pnlValido);
            this.Name = "TextData";
            this.Size = new System.Drawing.Size(281, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Panel pnlValido;
    }
}
