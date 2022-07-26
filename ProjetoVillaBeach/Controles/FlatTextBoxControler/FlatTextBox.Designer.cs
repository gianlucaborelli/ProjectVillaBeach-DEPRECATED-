namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    partial class FlatTextBox
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
            this.txtBox = new System.Windows.Forms.TextBox();
            this.pnlValido = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox.ForeColor = System.Drawing.Color.Gray;
            this.txtBox.Location = new System.Drawing.Point(5, 3);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(456, 16);
            this.txtBox.TabIndex = 0;
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            this.txtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBox_KeyUp);
            this.txtBox.Leave += new System.EventHandler(this.Leave_Event);
            this.txtBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTxtBox_Event);
            // 
            // pnlValido
            // 
            this.pnlValido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlValido.Location = new System.Drawing.Point(5, 31);
            this.pnlValido.Name = "pnlValido";
            this.pnlValido.Size = new System.Drawing.Size(456, 2);
            this.pnlValido.TabIndex = 1;
            // 
            // FlatTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlValido);
            this.Controls.Add(this.txtBox);
            this.Name = "FlatTextBox";
            this.Padding = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.Size = new System.Drawing.Size(464, 33);
            this.Load += new System.EventHandler(this.OnLoad_Event);
            this.Resize += new System.EventHandler(this.Controle_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Panel pnlValido;
    }
}
