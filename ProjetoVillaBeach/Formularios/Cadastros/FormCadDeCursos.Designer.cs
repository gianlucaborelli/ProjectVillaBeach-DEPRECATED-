namespace ProjetoVillaBeach.Formularios.Cadastros
{
    partial class FormCadDeCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadDeCursos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.dgvValoresModalidades = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluirValor = new System.Windows.Forms.Button();
            this.btnCancelarAlterarValor = new System.Windows.Forms.Button();
            this.flatTxtBoxValorModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtBoxInicioValorModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtBoxFimValorModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flatTxtBoxFimModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtBoxInicioModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtBoxNomeModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.txtObsModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvValoresModalidades)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1206, 90);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(85, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(641, 77);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro de Cursos";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnVoltar.Location = new System.Drawing.Point(20, 20);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(50, 50);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 741);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1206, 90);
            this.panel2.TabIndex = 5;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(20, 15);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.btnExcluir.Size = new System.Drawing.Size(190, 60);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(997, 15);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.btnSalvar.Size = new System.Drawing.Size(190, 60);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // dgvValoresModalidades
            // 
            this.dgvValoresModalidades.AllowUserToAddRows = false;
            this.dgvValoresModalidades.AllowUserToDeleteRows = false;
            this.dgvValoresModalidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvValoresModalidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvValoresModalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValoresModalidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvValoresModalidades.Location = new System.Drawing.Point(699, 8);
            this.dgvValoresModalidades.MultiSelect = false;
            this.dgvValoresModalidades.Name = "dgvValoresModalidades";
            this.dgvValoresModalidades.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvValoresModalidades, 8);
            this.dgvValoresModalidades.RowTemplate.Height = 25;
            this.dgvValoresModalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvValoresModalidades.Size = new System.Drawing.Size(494, 633);
            this.dgvValoresModalidades.TabIndex = 9;
            this.dgvValoresModalidades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvValoresModalidades_CellClick);
            this.dgvValoresModalidades.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DgvValoresModalidades_CellFormatting);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(13, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 376);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnAdicionar, 4, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnExcluirValor, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnCancelarAlterarValor, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtBoxValorModalidade, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtBoxInicioValorModalidade, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtBoxFimValorModalidade, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(664, 345);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(451, 108);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(210, 54);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAddModalidade_Click);
            // 
            // btnExcluirValor
            // 
            this.btnExcluirValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnExcluirValor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExcluirValor.FlatAppearance.BorderSize = 0;
            this.btnExcluirValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirValor.Location = new System.Drawing.Point(227, 108);
            this.btnExcluirValor.Name = "btnExcluirValor";
            this.btnExcluirValor.Size = new System.Drawing.Size(208, 54);
            this.btnExcluirValor.TabIndex = 4;
            this.btnExcluirValor.Text = "Excluir";
            this.btnExcluirValor.UseVisualStyleBackColor = false;
            this.btnExcluirValor.Click += new System.EventHandler(this.btnExcluirValor_Click);
            // 
            // btnCancelarAlterarValor
            // 
            this.btnCancelarAlterarValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnCancelarAlterarValor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCancelarAlterarValor.FlatAppearance.BorderSize = 0;
            this.btnCancelarAlterarValor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAlterarValor.Location = new System.Drawing.Point(3, 108);
            this.btnCancelarAlterarValor.Name = "btnCancelarAlterarValor";
            this.btnCancelarAlterarValor.Size = new System.Drawing.Size(208, 54);
            this.btnCancelarAlterarValor.TabIndex = 5;
            this.btnCancelarAlterarValor.Text = "Cancelar";
            this.btnCancelarAlterarValor.UseVisualStyleBackColor = false;
            this.btnCancelarAlterarValor.Click += new System.EventHandler(this.BtnCancelarAlteracaoValor_Click);
            // 
            // flatTxtBoxValorModalidade
            // 
            this.flatTxtBoxValorModalidade.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtBoxValorModalidade.BorderSize = 2;
            this.flatTxtBoxValorModalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTxtBoxValorModalidade.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtBoxValorModalidade.Location = new System.Drawing.Point(3, 8);
            this.flatTxtBoxValorModalidade.Multiline = false;
            this.flatTxtBoxValorModalidade.Name = "flatTxtBoxValorModalidade";
            this.flatTxtBoxValorModalidade.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtBoxValorModalidade.PasswordChar = false;
            this.flatTxtBoxValorModalidade.PlaceholderText = "Valor";
            this.flatTxtBoxValorModalidade.Required = true;
            this.flatTxtBoxValorModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxValorModalidade.Size = new System.Drawing.Size(208, 39);
            this.flatTxtBoxValorModalidade.TabIndex = 6;
            this.flatTxtBoxValorModalidade.UnderlinedStyle = true;
            this.flatTxtBoxValorModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxValorModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            // 
            // flatTxtBoxInicioValorModalidade
            // 
            this.flatTxtBoxInicioValorModalidade.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtBoxInicioValorModalidade.BorderSize = 2;
            this.flatTxtBoxInicioValorModalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTxtBoxInicioValorModalidade.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtBoxInicioValorModalidade.Location = new System.Drawing.Point(3, 58);
            this.flatTxtBoxInicioValorModalidade.Multiline = false;
            this.flatTxtBoxInicioValorModalidade.Name = "flatTxtBoxInicioValorModalidade";
            this.flatTxtBoxInicioValorModalidade.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtBoxInicioValorModalidade.PasswordChar = false;
            this.flatTxtBoxInicioValorModalidade.PlaceholderText = "Inicio do valor";
            this.flatTxtBoxInicioValorModalidade.Required = true;
            this.flatTxtBoxInicioValorModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxInicioValorModalidade.Size = new System.Drawing.Size(208, 39);
            this.flatTxtBoxInicioValorModalidade.TabIndex = 7;
            this.flatTxtBoxInicioValorModalidade.UnderlinedStyle = true;
            this.flatTxtBoxInicioValorModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxInicioValorModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.Date;
            // 
            // flatTxtBoxFimValorModalidade
            // 
            this.flatTxtBoxFimValorModalidade.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtBoxFimValorModalidade.BorderSize = 2;
            this.flatTxtBoxFimValorModalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTxtBoxFimValorModalidade.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtBoxFimValorModalidade.Location = new System.Drawing.Point(227, 58);
            this.flatTxtBoxFimValorModalidade.Multiline = false;
            this.flatTxtBoxFimValorModalidade.Name = "flatTxtBoxFimValorModalidade";
            this.flatTxtBoxFimValorModalidade.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtBoxFimValorModalidade.PasswordChar = false;
            this.flatTxtBoxFimValorModalidade.PlaceholderText = "Fim do valor";
            this.flatTxtBoxFimValorModalidade.Required = false;
            this.flatTxtBoxFimValorModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxFimValorModalidade.Size = new System.Drawing.Size(208, 39);
            this.flatTxtBoxFimValorModalidade.TabIndex = 8;
            this.flatTxtBoxFimValorModalidade.UnderlinedStyle = true;
            this.flatTxtBoxFimValorModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxFimValorModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.Date;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.dgvValoresModalidades, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.flatTxtBoxFimModalidade, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.flatTxtBoxInicioModalidade, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flatTxtBoxNomeModalidade, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtObsModalidade, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 90);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1206, 651);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // flatTxtBoxFimModalidade
            // 
            this.flatTxtBoxFimModalidade.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtBoxFimModalidade.BorderSize = 2;
            this.flatTxtBoxFimModalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTxtBoxFimModalidade.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtBoxFimModalidade.Location = new System.Drawing.Point(245, 58);
            this.flatTxtBoxFimModalidade.Multiline = false;
            this.flatTxtBoxFimModalidade.Name = "flatTxtBoxFimModalidade";
            this.flatTxtBoxFimModalidade.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtBoxFimModalidade.PasswordChar = false;
            this.flatTxtBoxFimModalidade.PlaceholderText = "Fim";
            this.flatTxtBoxFimModalidade.Required = false;
            this.flatTxtBoxFimModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxFimModalidade.Size = new System.Drawing.Size(216, 39);
            this.flatTxtBoxFimModalidade.TabIndex = 12;
            this.flatTxtBoxFimModalidade.UnderlinedStyle = true;
            this.flatTxtBoxFimModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxFimModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.Date;
            // 
            // flatTxtBoxInicioModalidade
            // 
            this.flatTxtBoxInicioModalidade.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtBoxInicioModalidade.BorderSize = 2;
            this.flatTxtBoxInicioModalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTxtBoxInicioModalidade.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtBoxInicioModalidade.Location = new System.Drawing.Point(13, 58);
            this.flatTxtBoxInicioModalidade.Multiline = false;
            this.flatTxtBoxInicioModalidade.Name = "flatTxtBoxInicioModalidade";
            this.flatTxtBoxInicioModalidade.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtBoxInicioModalidade.PasswordChar = false;
            this.flatTxtBoxInicioModalidade.PlaceholderText = "Inicio";
            this.flatTxtBoxInicioModalidade.Required = true;
            this.flatTxtBoxInicioModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxInicioModalidade.Size = new System.Drawing.Size(216, 39);
            this.flatTxtBoxInicioModalidade.TabIndex = 13;
            this.flatTxtBoxInicioModalidade.UnderlinedStyle = true;
            this.flatTxtBoxInicioModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxInicioModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.Date;
            this.flatTxtBoxInicioModalidade.Leave += new System.EventHandler(this.FlatTxtInicioModalidade_Leave);
            // 
            // flatTxtBoxNomeModalidade
            // 
            this.flatTxtBoxNomeModalidade.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtBoxNomeModalidade.BorderSize = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.flatTxtBoxNomeModalidade, 3);
            this.flatTxtBoxNomeModalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTxtBoxNomeModalidade.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtBoxNomeModalidade.Location = new System.Drawing.Point(13, 8);
            this.flatTxtBoxNomeModalidade.Multiline = false;
            this.flatTxtBoxNomeModalidade.Name = "flatTxtBoxNomeModalidade";
            this.flatTxtBoxNomeModalidade.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtBoxNomeModalidade.PasswordChar = false;
            this.flatTxtBoxNomeModalidade.PlaceholderText = "Nome";
            this.flatTxtBoxNomeModalidade.Required = true;
            this.flatTxtBoxNomeModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxNomeModalidade.Size = new System.Drawing.Size(448, 39);
            this.flatTxtBoxNomeModalidade.TabIndex = 0;
            this.flatTxtBoxNomeModalidade.UnderlinedStyle = true;
            this.flatTxtBoxNomeModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxNomeModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            this.flatTxtBoxNomeModalidade.Leave += new System.EventHandler(this.FlatTxtNomeModalidade_Leave);
            // 
            // txtObsModalidade
            // 
            this.txtObsModalidade.BorderColor = System.Drawing.Color.DarkBlue;
            this.txtObsModalidade.BorderSize = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.txtObsModalidade, 4);
            this.txtObsModalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObsModalidade.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtObsModalidade.Location = new System.Drawing.Point(13, 108);
            this.txtObsModalidade.Multiline = true;
            this.txtObsModalidade.Name = "txtObsModalidade";
            this.txtObsModalidade.Padding = new System.Windows.Forms.Padding(7);
            this.txtObsModalidade.PasswordChar = false;
            this.txtObsModalidade.PlaceholderText = "Observação";
            this.txtObsModalidade.Required = false;
            this.txtObsModalidade.RequirementsAreSatisfied = false;
            this.tableLayoutPanel1.SetRowSpan(this.txtObsModalidade, 2);
            this.txtObsModalidade.Size = new System.Drawing.Size(670, 146);
            this.txtObsModalidade.TabIndex = 14;
            this.txtObsModalidade.UnderlinedStyle = true;
            this.txtObsModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.txtObsModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            // 
            // FormCadDeCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(209)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1206, 831);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCadDeCursos";
            this.Text = "FormCadDeCursos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_OnLoad);
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValoresModalidades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridView dgvValoresModalidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelarAlterarValor;
        private System.Windows.Forms.Button btnExcluirValor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxFimModalidade;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxInicioModalidade;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxNomeModalidade;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxValorModalidade;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxInicioValorModalidade;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxFimValorModalidade;
        private Controles.FlatTextBoxControler.FlatTextBox txtObsModalidade;
    }
}