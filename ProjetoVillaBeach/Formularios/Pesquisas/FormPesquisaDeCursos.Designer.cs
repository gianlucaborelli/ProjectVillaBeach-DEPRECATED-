namespace ProjetoVillaBeach.Formularios.Pesquisas
{
    partial class FormPesquisaDeCursos
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
            this.btnAbrirCadastro = new System.Windows.Forms.Button();
            this.btnExcluirCadastro = new System.Windows.Forms.Button();
            this.btnCadastrarNovo = new System.Windows.Forms.Button();
            this.dgvModalidades = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.flatTxtBoxNomeModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidades)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbrirCadastro
            // 
            this.btnAbrirCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(120)))), ((int)(((byte)(205)))));
            this.btnAbrirCadastro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAbrirCadastro.FlatAppearance.BorderSize = 0;
            this.btnAbrirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirCadastro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbrirCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnAbrirCadastro.Location = new System.Drawing.Point(817, 751);
            this.btnAbrirCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbrirCadastro.Name = "btnAbrirCadastro";
            this.btnAbrirCadastro.Size = new System.Drawing.Size(376, 50);
            this.btnAbrirCadastro.TabIndex = 16;
            this.btnAbrirCadastro.Text = "Abrir Cadastro";
            this.btnAbrirCadastro.UseVisualStyleBackColor = false;
            this.btnAbrirCadastro.Click += new System.EventHandler(this.BtnAbrirCadastro_Click);
            // 
            // btnExcluirCadastro
            // 
            this.btnExcluirCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnExcluirCadastro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExcluirCadastro.FlatAppearance.BorderSize = 0;
            this.btnExcluirCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirCadastro.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnExcluirCadastro.Location = new System.Drawing.Point(19, 751);
            this.btnExcluirCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.btnExcluirCadastro.Name = "btnExcluirCadastro";
            this.btnExcluirCadastro.Size = new System.Drawing.Size(376, 50);
            this.btnExcluirCadastro.TabIndex = 15;
            this.btnExcluirCadastro.Text = "Excluir Cadastro";
            this.btnExcluirCadastro.UseVisualStyleBackColor = false;
            this.btnExcluirCadastro.Click += new System.EventHandler(this.BtnExcluirCadastro_Click);
            // 
            // btnCadastrarNovo
            // 
            this.btnCadastrarNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(151)))), ((int)(((byte)(83)))));
            this.btnCadastrarNovo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCadastrarNovo.FlatAppearance.BorderSize = 0;
            this.btnCadastrarNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarNovo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarNovo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnCadastrarNovo.Location = new System.Drawing.Point(418, 751);
            this.btnCadastrarNovo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrarNovo.Name = "btnCadastrarNovo";
            this.btnCadastrarNovo.Size = new System.Drawing.Size(376, 50);
            this.btnCadastrarNovo.TabIndex = 14;
            this.btnCadastrarNovo.Text = "Cadastrar Novo";
            this.btnCadastrarNovo.UseVisualStyleBackColor = false;
            this.btnCadastrarNovo.Click += new System.EventHandler(this.BtnCadastrarCurso_Click);
            // 
            // dgvModalidades
            // 
            this.dgvModalidades.AllowUserToAddRows = false;
            this.dgvModalidades.AllowUserToDeleteRows = false;
            this.dgvModalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvModalidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvModalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgvModalidades, 5);
            this.dgvModalidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModalidades.Location = new System.Drawing.Point(18, 198);
            this.dgvModalidades.Name = "dgvModalidades";
            this.dgvModalidades.ReadOnly = true;
            this.dgvModalidades.RowTemplate.Height = 25;
            this.dgvModalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModalidades.Size = new System.Drawing.Size(1176, 524);
            this.dgvModalidades.TabIndex = 17;
            this.dgvModalidades.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DgvModalidades_MouseDoubleClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnPesquisar.Location = new System.Drawing.Point(816, 138);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(378, 39);
            this.btnPesquisar.TabIndex = 18;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_Click);
            // 
            // flatTxtBoxNomeModalidade
            // 
            this.flatTxtBoxNomeModalidade.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtBoxNomeModalidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtBoxNomeModalidade.Location = new System.Drawing.Point(18, 18);
            this.flatTxtBoxNomeModalidade.Name = "flatTxtBoxNomeModalidade";
            this.flatTxtBoxNomeModalidade.Padding = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flatTxtBoxNomeModalidade.PlaceholderText = "Nome da Modalidade";
            this.flatTxtBoxNomeModalidade.Required = false;
            this.flatTxtBoxNomeModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxNomeModalidade.Size = new System.Drawing.Size(378, 33);
            this.flatTxtBoxNomeModalidade.TabIndex = 19;
            this.flatTxtBoxNomeModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxNomeModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
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
            this.tableLayoutPanel1.Controls.Add(this.flatTxtBoxNomeModalidade, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluirCadastro, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnCadastrarNovo, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnAbrirCadastro, 5, 8);
            this.tableLayoutPanel1.Controls.Add(this.dgvModalidades, 1, 7);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1213, 835);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // FormPesquisaDeCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(209)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1213, 835);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormPesquisaDeCursos";
            this.Text = "FormPesquisaDeCursos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvModalidades)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirCadastro;
        private System.Windows.Forms.Button btnExcluirCadastro;
        private System.Windows.Forms.Button btnCadastrarNovo;
        private System.Windows.Forms.DataGridView dgvModalidades;
        private System.Windows.Forms.Button btnPesquisar;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxNomeModalidade;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}