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
            this.SuspendLayout();
            // 
            // txtBox
            // 
            this.txtBox.BackColor = System.Drawing.SystemColors.Control;
            this.txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBox.ForeColor = System.Drawing.Color.Gray;
            this.txtBox.Location = new System.Drawing.Point(7, 7);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(236, 15);
            this.txtBox.TabIndex = 0;
            this.txtBox.Click += new System.EventHandler(this.TextBox_Click);
            this.txtBox.TextChanged += new System.EventHandler(this.FlatTextBox_TextChanged);
            this.txtBox.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress_Event);
            this.txtBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyUp);
            this.txtBox.Leave += new System.EventHandler(this.Leave_Event);
            this.txtBox.MouseEnter += new System.EventHandler(this.TextBox_MouseEnter);
            this.txtBox.MouseLeave += new System.EventHandler(this.TextBox_MouseLeave);
            this.txtBox.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTxtBox_Event);
            // 
            // FlatTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.txtBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "FlatTextBox";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 30);
            this.Load += new System.EventHandler(this.OnLoad_Event);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox;
    }
}
