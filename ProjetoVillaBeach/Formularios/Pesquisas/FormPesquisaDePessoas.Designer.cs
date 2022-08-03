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
            this.flatTxtEmail = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtRg = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnAbrirCadastro = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnPesquisar.Location = new System.Drawing.Point(819, 139);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(4);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(377, 37);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCadastrarNovo
            // 
            this.btnCadastrarNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(151)))), ((int)(((byte)(83)))));
            this.btnCadastrarNovo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCadastrarNovo.FlatAppearance.BorderSize = 0;
            this.btnCadastrarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarNovo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnCadastrarNovo.Location = new System.Drawing.Point(419, 740);
            this.btnCadastrarNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarNovo.Name = "btnCadastrarNovo";
            this.btnCadastrarNovo.Size = new System.Drawing.Size(377, 50);
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
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 5);
            this.dataGridView1.Location = new System.Drawing.Point(18, 198);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1179, 513);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // flatTxtNome
            // 
            this.flatTxtNome.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtNome.Location = new System.Drawing.Point(19, 19);
            this.flatTxtNome.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtNome.Name = "flatTxtNome";
            this.flatTxtNome.Padding = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flatTxtNome.PlaceholderText = "Nome";
            this.flatTxtNome.Required = false;
            this.flatTxtNome.RequirementsAreSatisfied = false;
            this.flatTxtNome.Size = new System.Drawing.Size(377, 35);
            this.flatTxtNome.TabIndex = 8;
            this.flatTxtNome.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtNome.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            // 
            // flatTxtCpf
            // 
            this.flatTxtCpf.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtCpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtCpf.Location = new System.Drawing.Point(19, 79);
            this.flatTxtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtCpf.Name = "flatTxtCpf";
            this.flatTxtCpf.Padding = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flatTxtCpf.PlaceholderText = "C.P.F.";
            this.flatTxtCpf.Required = false;
            this.flatTxtCpf.RequirementsAreSatisfied = false;
            this.flatTxtCpf.Size = new System.Drawing.Size(377, 33);
            this.flatTxtCpf.TabIndex = 9;
            this.flatTxtCpf.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtCpf.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.CPF;
            // 
            // flatTxtEmail
            // 
            this.flatTxtEmail.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtEmail.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtEmail.Location = new System.Drawing.Point(19, 139);
            this.flatTxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtEmail.Name = "flatTxtEmail";
            this.flatTxtEmail.Padding = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flatTxtEmail.PlaceholderText = "E-Mail";
            this.flatTxtEmail.Required = false;
            this.flatTxtEmail.RequirementsAreSatisfied = false;
            this.flatTxtEmail.Size = new System.Drawing.Size(377, 33);
            this.flatTxtEmail.TabIndex = 10;
            this.flatTxtEmail.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtEmail.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.EMail;
            // 
            // flatTxtRg
            // 
            this.flatTxtRg.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtRg.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtRg.Location = new System.Drawing.Point(419, 19);
            this.flatTxtRg.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtRg.Name = "flatTxtRg";
            this.flatTxtRg.Padding = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flatTxtRg.PlaceholderText = "R.G.";
            this.flatTxtRg.Required = false;
            this.flatTxtRg.RequirementsAreSatisfied = false;
            this.flatTxtRg.Size = new System.Drawing.Size(377, 33);
            this.flatTxtRg.TabIndex = 11;
            this.flatTxtRg.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtRg.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnExcluirCadastro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExcluirCadastro.FlatAppearance.BorderSize = 0;
            this.btnExcluirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCadastro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnExcluirCadastro.Location = new System.Drawing.Point(19, 740);
            this.btnExcluirCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(377, 50);
            this.btnExcluirCadastro.TabIndex = 12;
            this.btnExcluirCadastro.Text = "Excluir Cadastro";
            this.btnExcluirCadastro.UseVisualStyleBackColor = false;
            this.btnExcluirCadastro.Click += new System.EventHandler(this.BtnExcluirCadastro_Click);
            // 
            // btnAbrirCadastro
            // 
            this.btnAbrirCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(120)))), ((int)(((byte)(205)))));
            this.btnAbrirCadastro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAbrirCadastro.FlatAppearance.BorderSize = 0;
            this.btnAbrirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCadastro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnAbrirCadastro.Location = new System.Drawing.Point(819, 740);
            this.btnAbrirCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirCadastro.Name = "btnAbrirCadastro";
            this.btnAbrirCadastro.Size = new System.Drawing.Size(377, 50);
            this.btnAbrirCadastro.TabIndex = 13;
            this.btnAbrirCadastro.Text = "Abrir Cadastro";
            this.btnAbrirCadastro.UseVisualStyleBackColor = false;
            this.btnAbrirCadastro.Click += new System.EventHandler(this.btnAbrirCadastro_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.flatTxtNome, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.flatTxtRg, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluirCadastro, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrarNovo, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.flatTxtCpf, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flatTxtEmail, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnAbrirCadastro, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnPesquisar, 5, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1216, 824);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // FormPesquisaDePessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(209)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1216, 824);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPesquisaDePessoas";
            this.Text = "PesquisaPessoasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrarNovo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtNome;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtCpf;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtEmail;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtRg;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Button btnAbrirCadastro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}