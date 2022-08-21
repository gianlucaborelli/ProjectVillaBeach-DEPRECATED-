namespace ProjetoVillaBeach.Formularios.Cadastros
{
    partial class FormCadastroDePessoas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDePessoas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDadosPessoais = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flatTxtFiliacao2 = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtRg = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtFiliacao1 = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtNome = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtCpf = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtDn = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.flpContatos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddEndereco = new System.Windows.Forms.Button();
            this.flpEndereco = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddContatos = new System.Windows.Forms.Button();
            this.imageCapture1 = new ProjetoVillaBeach.Controles.ImageCaptureControler.ImageCapture();
            this.tbContatos = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbDadosPessoais.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 730);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 90);
            this.panel2.TabIndex = 1;
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
            this.btnSalvar.Location = new System.Drawing.Point(1007, 15);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(10, 0, 35, 0);
            this.btnSalvar.Size = new System.Drawing.Size(190, 60);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbDadosPessoais);
            this.tabControl1.Controls.Add(this.tbContatos);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1220, 640);
            this.tabControl1.TabIndex = 2;
            // 
            // tbDadosPessoais
            // 
            this.tbDadosPessoais.AutoScroll = true;
            this.tbDadosPessoais.Controls.Add(this.tableLayoutPanel2);
            this.tbDadosPessoais.Location = new System.Drawing.Point(4, 30);
            this.tbDadosPessoais.Name = "tbDadosPessoais";
            this.tbDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tbDadosPessoais.Size = new System.Drawing.Size(1212, 606);
            this.tbDadosPessoais.TabIndex = 0;
            this.tbDadosPessoais.Text = "Dados Pessoais";
            this.tbDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 11;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.Controls.Add(this.flatTxtFiliacao2, 3, 5);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtRg, 7, 5);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtFiliacao1, 3, 3);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtNome, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtCpf, 7, 3);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtDn, 7, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 1, 13);
            this.tableLayoutPanel2.Controls.Add(this.imageCapture1, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 15;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1206, 600);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // flatTxtFiliacao2
            // 
            this.flatTxtFiliacao2.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtFiliacao2.BorderSize = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.flatTxtFiliacao2, 3);
            this.flatTxtFiliacao2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTxtFiliacao2.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtFiliacao2.Location = new System.Drawing.Point(248, 98);
            this.flatTxtFiliacao2.Multiline = false;
            this.flatTxtFiliacao2.Name = "flatTxtFiliacao2";
            this.flatTxtFiliacao2.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtFiliacao2.PasswordChar = false;
            this.flatTxtFiliacao2.PlaceholderText = "Filiação 2";
            this.flatTxtFiliacao2.Required = false;
            this.flatTxtFiliacao2.RequirementsAreSatisfied = false;
            this.flatTxtFiliacao2.Size = new System.Drawing.Size(469, 39);
            this.flatTxtFiliacao2.TabIndex = 7;
            this.flatTxtFiliacao2.UnderlinedStyle = true;
            this.flatTxtFiliacao2.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtFiliacao2.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            this.flatTxtFiliacao2.Leave += new System.EventHandler(this.FlatTxtBoxFiliacao2_Leave);
            // 
            // flatTxtRg
            // 
            this.flatTxtRg.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtRg.BorderSize = 2;
            this.flatTxtRg.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtRg.Location = new System.Drawing.Point(728, 98);
            this.flatTxtRg.Multiline = false;
            this.flatTxtRg.Name = "flatTxtRg";
            this.flatTxtRg.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtRg.PasswordChar = false;
            this.flatTxtRg.PlaceholderText = "R.G.";
            this.flatTxtRg.Required = false;
            this.flatTxtRg.RequirementsAreSatisfied = false;
            this.flatTxtRg.Size = new System.Drawing.Size(229, 39);
            this.flatTxtRg.TabIndex = 8;
            this.flatTxtRg.UnderlinedStyle = true;
            this.flatTxtRg.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtRg.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            this.flatTxtRg.Leave += new System.EventHandler(this.FlatTxtBoxRG_Leave);
            // 
            // flatTxtFiliacao1
            // 
            this.flatTxtFiliacao1.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtFiliacao1.BorderSize = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.flatTxtFiliacao1, 3);
            this.flatTxtFiliacao1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTxtFiliacao1.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtFiliacao1.Location = new System.Drawing.Point(248, 53);
            this.flatTxtFiliacao1.Multiline = false;
            this.flatTxtFiliacao1.Name = "flatTxtFiliacao1";
            this.flatTxtFiliacao1.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtFiliacao1.PasswordChar = false;
            this.flatTxtFiliacao1.PlaceholderText = "Filiação 1";
            this.flatTxtFiliacao1.Required = false;
            this.flatTxtFiliacao1.RequirementsAreSatisfied = false;
            this.flatTxtFiliacao1.Size = new System.Drawing.Size(469, 39);
            this.flatTxtFiliacao1.TabIndex = 9;
            this.flatTxtFiliacao1.UnderlinedStyle = true;
            this.flatTxtFiliacao1.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtFiliacao1.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            this.flatTxtFiliacao1.Leave += new System.EventHandler(this.FlatTxtBoxFiliacao1_Leave);
            // 
            // flatTxtNome
            // 
            this.flatTxtNome.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtNome.BorderSize = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.flatTxtNome, 3);
            this.flatTxtNome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flatTxtNome.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtNome.Location = new System.Drawing.Point(248, 8);
            this.flatTxtNome.Multiline = false;
            this.flatTxtNome.Name = "flatTxtNome";
            this.flatTxtNome.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtNome.PasswordChar = false;
            this.flatTxtNome.PlaceholderText = "Nome";
            this.flatTxtNome.Required = false;
            this.flatTxtNome.RequirementsAreSatisfied = false;
            this.flatTxtNome.Size = new System.Drawing.Size(469, 39);
            this.flatTxtNome.TabIndex = 4;
            this.flatTxtNome.UnderlinedStyle = true;
            this.flatTxtNome.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtNome.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            this.flatTxtNome.Leave += new System.EventHandler(this.NomeFlatTextBox_Leave);
            // 
            // flatTxtCpf
            // 
            this.flatTxtCpf.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtCpf.BorderSize = 2;
            this.flatTxtCpf.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtCpf.Location = new System.Drawing.Point(728, 53);
            this.flatTxtCpf.Multiline = false;
            this.flatTxtCpf.Name = "flatTxtCpf";
            this.flatTxtCpf.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtCpf.PasswordChar = false;
            this.flatTxtCpf.PlaceholderText = "C.P.F.";
            this.flatTxtCpf.Required = false;
            this.flatTxtCpf.RequirementsAreSatisfied = false;
            this.flatTxtCpf.Size = new System.Drawing.Size(229, 39);
            this.flatTxtCpf.TabIndex = 5;
            this.flatTxtCpf.UnderlinedStyle = true;
            this.flatTxtCpf.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtCpf.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.CPF;
            this.flatTxtCpf.Leave += new System.EventHandler(this.FlatTxtBoxCPF_Leave);
            // 
            // flatTxtDn
            // 
            this.flatTxtDn.BorderColor = System.Drawing.Color.DarkBlue;
            this.flatTxtDn.BorderSize = 2;
            this.flatTxtDn.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flatTxtDn.Location = new System.Drawing.Point(728, 8);
            this.flatTxtDn.Multiline = false;
            this.flatTxtDn.Name = "flatTxtDn";
            this.flatTxtDn.Padding = new System.Windows.Forms.Padding(7);
            this.flatTxtDn.PasswordChar = false;
            this.flatTxtDn.PlaceholderText = "Nascimento";
            this.flatTxtDn.Required = false;
            this.flatTxtDn.RequirementsAreSatisfied = false;
            this.flatTxtDn.Size = new System.Drawing.Size(229, 39);
            this.flatTxtDn.TabIndex = 6;
            this.flatTxtDn.UnderlinedStyle = true;
            this.flatTxtDn.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtDn.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.Date;
            this.flatTxtDn.Leave += new System.EventHandler(this.FlatTxtBoxDN_Leave);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel6, 9);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.flpContatos, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnAddEndereco, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.flpEndereco, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnAddContatos, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(8, 276);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1189, 321);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // flpContatos
            // 
            this.flpContatos.AutoScroll = true;
            this.flpContatos.AutoSize = true;
            this.flpContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContatos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flpContatos.Location = new System.Drawing.Point(597, 43);
            this.flpContatos.Name = "flpContatos";
            this.flpContatos.Size = new System.Drawing.Size(589, 275);
            this.flpContatos.TabIndex = 6;
            this.flpContatos.WrapContents = false;
            // 
            // btnAddEndereco
            // 
            this.btnAddEndereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnAddEndereco.FlatAppearance.BorderSize = 0;
            this.btnAddEndereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEndereco.Location = new System.Drawing.Point(3, 3);
            this.btnAddEndereco.Name = "btnAddEndereco";
            this.btnAddEndereco.Size = new System.Drawing.Size(204, 34);
            this.btnAddEndereco.TabIndex = 6;
            this.btnAddEndereco.Text = "Adicionar Endereço";
            this.btnAddEndereco.UseVisualStyleBackColor = false;
            this.btnAddEndereco.Click += new System.EventHandler(this.BtnAddEndereco_Click);
            // 
            // flpEndereco
            // 
            this.flpEndereco.AutoScroll = true;
            this.flpEndereco.AutoSize = true;
            this.flpEndereco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpEndereco.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEndereco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flpEndereco.Location = new System.Drawing.Point(3, 43);
            this.flpEndereco.Name = "flpEndereco";
            this.flpEndereco.Size = new System.Drawing.Size(588, 275);
            this.flpEndereco.TabIndex = 5;
            this.flpEndereco.WrapContents = false;
            // 
            // btnAddContatos
            // 
            this.btnAddContatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnAddContatos.FlatAppearance.BorderSize = 0;
            this.btnAddContatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContatos.Location = new System.Drawing.Point(597, 3);
            this.btnAddContatos.Name = "btnAddContatos";
            this.btnAddContatos.Size = new System.Drawing.Size(204, 34);
            this.btnAddContatos.TabIndex = 7;
            this.btnAddContatos.Text = "Adicionar Contato";
            this.btnAddContatos.UseVisualStyleBackColor = false;
            // 
            // imageCapture1
            // 
            this.imageCapture1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageCapture1.Location = new System.Drawing.Point(9, 9);
            this.imageCapture1.Margin = new System.Windows.Forms.Padding(4);
            this.imageCapture1.Name = "imageCapture1";
            this.tableLayoutPanel2.SetRowSpan(this.imageCapture1, 11);
            this.imageCapture1.Size = new System.Drawing.Size(227, 278);
            this.imageCapture1.TabIndex = 10;
            // 
            // tbContatos
            // 
            this.tbContatos.AutoScroll = true;
            this.tbContatos.Location = new System.Drawing.Point(4, 24);
            this.tbContatos.Name = "tbContatos";
            this.tbContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbContatos.Size = new System.Drawing.Size(1212, 612);
            this.tbContatos.TabIndex = 1;
            this.tbContatos.Text = "Contatos";
            this.tbContatos.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 90);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(85, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(652, 77);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro de Pessoa";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnVoltar.Location = new System.Drawing.Point(20, 20);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(50, 50);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1220, 640);
            this.panel3.TabIndex = 4;
            // 
            // FormCadastroDePessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(209)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1220, 820);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadastroDePessoas";
            this.Text = "CadastroPessoa";
            this.Load += new System.EventHandler(this.Form_OnLoad);
            this.SizeChanged += new System.EventHandler(this.CadastroPessoa_SizeChanged);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbDadosPessoais.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbDadosPessoais;
        private System.Windows.Forms.TabPage tbContatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        
        private System.Windows.Forms.Button btnAddEndereco;
        private System.Windows.Forms.FlowLayoutPanel flpEndereco;
        private System.Windows.Forms.FlowLayoutPanel flpContatos;
        private System.Windows.Forms.Button btnAddContatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel3;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtFiliacao2;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtRg;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtFiliacao1;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtNome;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtCpf;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtDn;
        private Controles.ImageCaptureControler.ImageCapture imageCapture1;
    }
}