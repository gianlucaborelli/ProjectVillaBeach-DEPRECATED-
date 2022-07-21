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
            this.flatTxtBoxNomeModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtBoxInicioModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtBoxFimModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.dgvValoresModalidades = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flatTxtBoxValorModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnExcluirValor = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.flatTxtBoxInicioValorModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtBoxFimValorModalidade = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.txtObsModalidade = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.panel1.Size = new System.Drawing.Size(1215, 110);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(114, 15);
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
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnVoltar.Location = new System.Drawing.Point(16, 16);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 75);
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
            this.panel2.Location = new System.Drawing.Point(0, 744);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1215, 110);
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
            this.btnExcluir.Location = new System.Drawing.Point(16, 21);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.btnExcluir.Size = new System.Drawing.Size(202, 75);
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
            this.btnSalvar.Location = new System.Drawing.Point(999, 21);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.btnSalvar.Size = new System.Drawing.Size(202, 75);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // flatTxtBoxNomeModalidade
            // 
            this.flatTxtBoxNomeModalidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTxtBoxNomeModalidade.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel1.SetColumnSpan(this.flatTxtBoxNomeModalidade, 4);
            this.flatTxtBoxNomeModalidade.Location = new System.Drawing.Point(20, 20);
            this.flatTxtBoxNomeModalidade.Margin = new System.Windows.Forms.Padding(5);
            this.flatTxtBoxNomeModalidade.Name = "flatTxtBoxNomeModalidade";
            this.flatTxtBoxNomeModalidade.Padding = new System.Windows.Forms.Padding(9, 5, 5, 0);
            this.flatTxtBoxNomeModalidade.PlaceholderText = "Nome da Modalidade";
            this.flatTxtBoxNomeModalidade.Required = false;
            this.flatTxtBoxNomeModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxNomeModalidade.Size = new System.Drawing.Size(656, 34);
            this.flatTxtBoxNomeModalidade.TabIndex = 6;
            this.flatTxtBoxNomeModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxNomeModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            this.flatTxtBoxNomeModalidade.Leave += new System.EventHandler(this.txtNomeModalidade_Leave);
            // 
            // flatTxtBoxInicioModalidade
            // 
            this.flatTxtBoxInicioModalidade.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtBoxInicioModalidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtBoxInicioModalidade.Location = new System.Drawing.Point(252, 80);
            this.flatTxtBoxInicioModalidade.Margin = new System.Windows.Forms.Padding(5);
            this.flatTxtBoxInicioModalidade.Name = "flatTxtBoxInicioModalidade";
            this.flatTxtBoxInicioModalidade.Padding = new System.Windows.Forms.Padding(9, 5, 5, 0);
            this.flatTxtBoxInicioModalidade.PlaceholderText = "Início";
            this.flatTxtBoxInicioModalidade.Required = false;
            this.flatTxtBoxInicioModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxInicioModalidade.Size = new System.Drawing.Size(207, 34);
            this.flatTxtBoxInicioModalidade.TabIndex = 7;
            this.flatTxtBoxInicioModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxInicioModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.Date;
            this.flatTxtBoxInicioModalidade.Leave += new System.EventHandler(this.flatTxtInicioModalidade_Leave);
            // 
            // flatTxtBoxFimModalidade
            // 
            this.flatTxtBoxFimModalidade.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtBoxFimModalidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtBoxFimModalidade.Location = new System.Drawing.Point(20, 80);
            this.flatTxtBoxFimModalidade.Margin = new System.Windows.Forms.Padding(5);
            this.flatTxtBoxFimModalidade.Name = "flatTxtBoxFimModalidade";
            this.flatTxtBoxFimModalidade.Padding = new System.Windows.Forms.Padding(9, 5, 5, 0);
            this.flatTxtBoxFimModalidade.PlaceholderText = "Fim";
            this.flatTxtBoxFimModalidade.Required = false;
            this.flatTxtBoxFimModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxFimModalidade.Size = new System.Drawing.Size(207, 34);
            this.flatTxtBoxFimModalidade.TabIndex = 8;
            this.flatTxtBoxFimModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxFimModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.Date;
            this.flatTxtBoxFimModalidade.Leave += new System.EventHandler(this.FlatTxtFimModalide_Leave);
            // 
            // dgvValoresModalidades
            // 
            this.dgvValoresModalidades.AllowUserToAddRows = false;
            this.dgvValoresModalidades.AllowUserToDeleteRows = false;
            this.dgvValoresModalidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvValoresModalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvValoresModalidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvValoresModalidades.Location = new System.Drawing.Point(699, 18);
            this.dgvValoresModalidades.Name = "dgvValoresModalidades";
            this.dgvValoresModalidades.ReadOnly = true;
            this.tableLayoutPanel1.SetRowSpan(this.dgvValoresModalidades, 8);
            this.dgvValoresModalidades.RowTemplate.Height = 25;
            this.dgvValoresModalidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvValoresModalidades.Size = new System.Drawing.Size(494, 596);
            this.dgvValoresModalidades.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 4);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(18, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 329);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Valores";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.flatTxtBoxValorModalidade, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAdicionar, 5, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnExcluirValor, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnAlterar, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtBoxInicioValorModalidade, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtBoxFimValorModalidade, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(654, 298);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // flatTxtBoxValorModalidade
            // 
            this.flatTxtBoxValorModalidade.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtBoxValorModalidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtBoxValorModalidade.Location = new System.Drawing.Point(13, 13);
            this.flatTxtBoxValorModalidade.Name = "flatTxtBoxValorModalidade";
            this.flatTxtBoxValorModalidade.Padding = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flatTxtBoxValorModalidade.PlaceholderText = "Valor";
            this.flatTxtBoxValorModalidade.Required = false;
            this.flatTxtBoxValorModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxValorModalidade.Size = new System.Drawing.Size(192, 33);
            this.flatTxtBoxValorModalidade.TabIndex = 0;
            this.flatTxtBoxValorModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxValorModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnAdicionar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(439, 133);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(192, 54);
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
            this.btnExcluirValor.Location = new System.Drawing.Point(226, 133);
            this.btnExcluirValor.Name = "btnExcluirValor";
            this.btnExcluirValor.Size = new System.Drawing.Size(192, 54);
            this.btnExcluirValor.TabIndex = 4;
            this.btnExcluirValor.Text = "Excluir Valor";
            this.btnExcluirValor.UseVisualStyleBackColor = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnAlterar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAlterar.FlatAppearance.BorderSize = 0;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Location = new System.Drawing.Point(13, 133);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(192, 54);
            this.btnAlterar.TabIndex = 5;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // flatTxtBoxInicioValorModalidade
            // 
            this.flatTxtBoxInicioValorModalidade.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtBoxInicioValorModalidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtBoxInicioValorModalidade.Location = new System.Drawing.Point(13, 73);
            this.flatTxtBoxInicioValorModalidade.Name = "flatTxtBoxInicioValorModalidade";
            this.flatTxtBoxInicioValorModalidade.Padding = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flatTxtBoxInicioValorModalidade.PlaceholderText = "Início deste valor";
            this.flatTxtBoxInicioValorModalidade.Required = false;
            this.flatTxtBoxInicioValorModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxInicioValorModalidade.Size = new System.Drawing.Size(192, 33);
            this.flatTxtBoxInicioValorModalidade.TabIndex = 1;
            this.flatTxtBoxInicioValorModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxInicioValorModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.Date;
            // 
            // flatTxtBoxFimValorModalidade
            // 
            this.flatTxtBoxFimValorModalidade.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtBoxFimValorModalidade.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtBoxFimValorModalidade.Location = new System.Drawing.Point(226, 73);
            this.flatTxtBoxFimValorModalidade.Name = "flatTxtBoxFimValorModalidade";
            this.flatTxtBoxFimValorModalidade.Padding = new System.Windows.Forms.Padding(5, 3, 3, 0);
            this.flatTxtBoxFimValorModalidade.PlaceholderText = "Fim deste valor";
            this.flatTxtBoxFimValorModalidade.Required = false;
            this.flatTxtBoxFimValorModalidade.RequirementsAreSatisfied = false;
            this.flatTxtBoxFimValorModalidade.Size = new System.Drawing.Size(192, 33);
            this.flatTxtBoxFimValorModalidade.TabIndex = 2;
            this.flatTxtBoxFimValorModalidade.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtBoxFimValorModalidade.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.Date;
            // 
            // txtObsModalidade
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtObsModalidade, 4);
            this.txtObsModalidade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObsModalidade.Location = new System.Drawing.Point(18, 138);
            this.txtObsModalidade.Multiline = true;
            this.txtObsModalidade.Name = "txtObsModalidade";
            this.tableLayoutPanel1.SetRowSpan(this.txtObsModalidade, 2);
            this.txtObsModalidade.Size = new System.Drawing.Size(660, 126);
            this.txtObsModalidade.TabIndex = 11;
            this.txtObsModalidade.Leave += new System.EventHandler(this.TxtObsModalidade_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtObsModalidade, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.flatTxtBoxNomeModalidade, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flatTxtBoxFimModalidade, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.flatTxtBoxInicioModalidade, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.dgvValoresModalidades, 6, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42858F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1215, 634);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // FormCadDeCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(209)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1215, 854);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormCadDeCursos";
            this.Text = "FormCadDeCursos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvValoresModalidades)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxNomeModalidade;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxInicioModalidade;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxFimModalidade;
        private System.Windows.Forms.DataGridView dgvValoresModalidades;
        private System.Windows.Forms.GroupBox groupBox1;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxValorModalidade;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxFimValorModalidade;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtBoxInicioValorModalidade;
        private System.Windows.Forms.TextBox txtObsModalidade;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluirValor;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}