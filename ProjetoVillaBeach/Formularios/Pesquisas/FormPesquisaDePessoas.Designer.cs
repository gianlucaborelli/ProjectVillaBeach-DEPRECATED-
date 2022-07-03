namespace ProjetoVillaBeach.Formularios.Pesquisas
{
    partial class FormPesquisaDePessoas
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
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrarNovo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flatTxtNome = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtCpf = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnPesquisar.Location = new System.Drawing.Point(824, 123);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(200, 50);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCadastrarNovo
            // 
            this.btnCadastrarNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastrarNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnCadastrarNovo.FlatAppearance.BorderSize = 0;
            this.btnCadastrarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnCadastrarNovo.Location = new System.Drawing.Point(824, 695);
            this.btnCadastrarNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarNovo.Name = "btnCadastrarNovo";
            this.btnCadastrarNovo.Size = new System.Drawing.Size(200, 50);
            this.btnCadastrarNovo.TabIndex = 1;
            this.btnCadastrarNovo.Text = "Cadastrar Novo";
            this.btnCadastrarNovo.UseVisualStyleBackColor = false;
            this.btnCadastrarNovo.Click += new System.EventHandler(this.btnCadastrarNovo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(990, 448);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // flatTxtNome
            // 
            this.flatTxtNome.BackColor = System.Drawing.Color.Silver;
            this.flatTxtNome.Location = new System.Drawing.Point(34, 39);
            this.flatTxtNome.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtNome.Name = "flatTxtNome";
            this.flatTxtNome.PlaceholderText = "Nome";
            this.flatTxtNome.Required = false;
            this.flatTxtNome.RequirementsAreSatisfied = false;
            this.flatTxtNome.Size = new System.Drawing.Size(365, 35);
            this.flatTxtNome.TabIndex = 8;
            this.flatTxtNome.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtNome.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            // 
            // flatTxtCpf
            // 
            this.flatTxtCpf.BackColor = System.Drawing.Color.Silver;
            this.flatTxtCpf.Location = new System.Drawing.Point(34, 98);
            this.flatTxtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtCpf.Name = "flatTxtCpf";
            this.flatTxtCpf.PlaceholderText = "C.P.F.";
            this.flatTxtCpf.Required = false;
            this.flatTxtCpf.RequirementsAreSatisfied = false;
            this.flatTxtCpf.Size = new System.Drawing.Size(365, 33);
            this.flatTxtCpf.TabIndex = 9;
            this.flatTxtCpf.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtCpf.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.CPF;
            // 
            // FormPesquisaDePessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(209)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1055, 774);
            this.Controls.Add(this.flatTxtCpf);
            this.Controls.Add(this.flatTxtNome);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCadastrarNovo);
            this.Controls.Add(this.btnPesquisar);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPesquisaDePessoas";
            this.Text = "PesquisaPessoasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrarNovo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtNome;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtCpf;
    }
}