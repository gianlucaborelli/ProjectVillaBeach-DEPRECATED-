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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pbCalendar = new System.Windows.Forms.PictureBox();
            this.flatTxtDn = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtNome = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.flatTxtCpf = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtRg = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.flatTxtFiliacao1 = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtFiliacao2 = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.flpContatos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddEndereco = new System.Windows.Forms.Button();
            this.flpEndereco = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddContatos = new System.Windows.Forms.Button();
            this.tbContatos = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbDadosPessoais.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendar)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 710);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 110);
            this.panel2.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(63)))), ((int)(((byte)(73)))));
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(19, 19);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(202, 75);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(1001, 19);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(202, 75);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tbDadosPessoais);
            this.tabControl1.Controls.Add(this.tbContatos);
            this.tabControl1.Location = new System.Drawing.Point(12, 113);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1196, 593);
            this.tabControl1.TabIndex = 2;
            // 
            // tbDadosPessoais
            // 
            this.tbDadosPessoais.AutoScroll = true;
            this.tbDadosPessoais.Controls.Add(this.tableLayoutPanel2);
            this.tbDadosPessoais.Location = new System.Drawing.Point(4, 30);
            this.tbDadosPessoais.Name = "tbDadosPessoais";
            this.tbDadosPessoais.Padding = new System.Windows.Forms.Padding(3);
            this.tbDadosPessoais.Size = new System.Drawing.Size(1188, 559);
            this.tbDadosPessoais.TabIndex = 0;
            this.tbDadosPessoais.Text = "Dados Pessoais";
            this.tbDadosPessoais.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1182, 553);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.Controls.Add(this.pbCalendar, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.flatTxtDn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flatTxtNome, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(396, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(388, 132);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // pbCalendar
            // 
            this.pbCalendar.Image = global::ProjetoVillaBeach.Properties.Resources.Calendar_48px;
            this.pbCalendar.Location = new System.Drawing.Point(351, 69);
            this.pbCalendar.Name = "pbCalendar";
            this.pbCalendar.Size = new System.Drawing.Size(30, 35);
            this.pbCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCalendar.TabIndex = 3;
            this.pbCalendar.TabStop = false;
            this.pbCalendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // flatTxtDn
            // 
            this.flatTxtDn.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtDn.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtDn.Location = new System.Drawing.Point(4, 70);
            this.flatTxtDn.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtDn.Name = "flatTxtDn";
            this.flatTxtDn.PlaceholderText = "Data de Nascimento";
            this.flatTxtDn.Required = false;
            this.flatTxtDn.RequirementsAreSatisfied = false;
            this.flatTxtDn.Size = new System.Drawing.Size(340, 34);
            this.flatTxtDn.TabIndex = 5;
            this.flatTxtDn.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtDn.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.Date;
            this.flatTxtDn.Validated += new System.EventHandler(this.DataDeNascimentoFlatTextBox_Valited);
            // 
            // flatTxtNome
            // 
            this.flatTxtNome.BackColor = System.Drawing.Color.Gainsboro;
            this.tableLayoutPanel3.SetColumnSpan(this.flatTxtNome, 2);
            this.flatTxtNome.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtNome.Location = new System.Drawing.Point(4, 4);
            this.flatTxtNome.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtNome.Name = "flatTxtNome";
            this.flatTxtNome.PlaceholderText = "Nome";
            this.flatTxtNome.Required = true;
            this.flatTxtNome.RequirementsAreSatisfied = false;
            this.flatTxtNome.Size = new System.Drawing.Size(380, 34);
            this.flatTxtNome.TabIndex = 0;
            this.flatTxtNome.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtNome.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            this.flatTxtNome.Leave += new System.EventHandler(this.NomeFlatTextBox_Leave);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Controls.Add(this.flatTxtCpf, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.flatTxtRg, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(790, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(389, 132);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // flatTxtCpf
            // 
            this.flatTxtCpf.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtCpf.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtCpf.Location = new System.Drawing.Point(4, 4);
            this.flatTxtCpf.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtCpf.Name = "flatTxtCpf";
            this.flatTxtCpf.PlaceholderText = "C.P.F.";
            this.flatTxtCpf.Required = false;
            this.flatTxtCpf.RequirementsAreSatisfied = false;
            this.flatTxtCpf.Size = new System.Drawing.Size(381, 34);
            this.flatTxtCpf.TabIndex = 4;
            this.flatTxtCpf.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtCpf.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.CPF;
            this.flatTxtCpf.Validated += new System.EventHandler(this.CpfFlatTextBox_Validated);
            // 
            // flatTxtRg
            // 
            this.flatTxtRg.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtRg.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtRg.Location = new System.Drawing.Point(4, 70);
            this.flatTxtRg.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtRg.Name = "flatTxtRg";
            this.flatTxtRg.PlaceholderText = "R.G.";
            this.flatTxtRg.Required = false;
            this.flatTxtRg.RequirementsAreSatisfied = false;
            this.flatTxtRg.Size = new System.Drawing.Size(381, 33);
            this.flatTxtRg.TabIndex = 5;
            this.flatTxtRg.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtRg.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            this.flatTxtRg.Validated += new System.EventHandler(this.RgFlatTextBox_Valited);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.flatTxtFiliacao1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.flatTxtFiliacao2, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(396, 141);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(388, 132);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // flatTxtFiliacao1
            // 
            this.flatTxtFiliacao1.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtFiliacao1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtFiliacao1.Location = new System.Drawing.Point(4, 4);
            this.flatTxtFiliacao1.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtFiliacao1.Name = "flatTxtFiliacao1";
            this.flatTxtFiliacao1.PlaceholderText = "Filiação 1";
            this.flatTxtFiliacao1.Required = false;
            this.flatTxtFiliacao1.RequirementsAreSatisfied = false;
            this.flatTxtFiliacao1.Size = new System.Drawing.Size(380, 34);
            this.flatTxtFiliacao1.TabIndex = 0;
            this.flatTxtFiliacao1.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtFiliacao1.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            this.flatTxtFiliacao1.Validated += new System.EventHandler(this.Filiacao1FlatTextBox_Valited);
            // 
            // flatTxtFiliacao2
            // 
            this.flatTxtFiliacao2.BackColor = System.Drawing.Color.Gainsboro;
            this.flatTxtFiliacao2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flatTxtFiliacao2.Location = new System.Drawing.Point(4, 70);
            this.flatTxtFiliacao2.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtFiliacao2.Name = "flatTxtFiliacao2";
            this.flatTxtFiliacao2.PlaceholderText = "Filiação 2";
            this.flatTxtFiliacao2.Required = false;
            this.flatTxtFiliacao2.RequirementsAreSatisfied = false;
            this.flatTxtFiliacao2.Size = new System.Drawing.Size(380, 34);
            this.flatTxtFiliacao2.TabIndex = 1;
            this.flatTxtFiliacao2.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtFiliacao2.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            this.flatTxtFiliacao2.Validated += new System.EventHandler(this.Filiacao2FlatTextBox_Valited);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel2.SetColumnSpan(this.tableLayoutPanel6, 3);
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.flpContatos, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnAddEndereco, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.flpEndereco, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.btnAddContatos, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 279);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel6, 2);
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1176, 271);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // flpContatos
            // 
            this.flpContatos.AutoScroll = true;
            this.flpContatos.AutoSize = true;
            this.flpContatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpContatos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flpContatos.Location = new System.Drawing.Point(591, 43);
            this.flpContatos.Name = "flpContatos";
            this.flpContatos.Size = new System.Drawing.Size(582, 225);
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
            this.flpEndereco.Size = new System.Drawing.Size(582, 225);
            this.flpEndereco.TabIndex = 5;
            this.flpEndereco.WrapContents = false;
            // 
            // btnAddContatos
            // 
            this.btnAddContatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnAddContatos.FlatAppearance.BorderSize = 0;
            this.btnAddContatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContatos.Location = new System.Drawing.Point(591, 3);
            this.btnAddContatos.Name = "btnAddContatos";
            this.btnAddContatos.Size = new System.Drawing.Size(204, 34);
            this.btnAddContatos.TabIndex = 7;
            this.btnAddContatos.Text = "Adicionar Contato";
            this.btnAddContatos.UseVisualStyleBackColor = false;
            // 
            // tbContatos
            // 
            this.tbContatos.AutoScroll = true;
            this.tbContatos.Location = new System.Drawing.Point(4, 30);
            this.tbContatos.Name = "tbContatos";
            this.tbContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbContatos.Size = new System.Drawing.Size(1188, 559);
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
            this.panel1.Size = new System.Drawing.Size(1220, 110);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
            this.label1.Location = new System.Drawing.Point(107, 12);
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
            this.btnVoltar.Location = new System.Drawing.Point(16, 14);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 75);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "<";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // FormCadastroDePessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(209)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(1220, 820);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormCadastroDePessoas";
            this.Text = "CadastroPessoa";
            this.SizeChanged += new System.EventHandler(this.CadastroPessoa_SizeChanged);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbDadosPessoais.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendar)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtNome;
        
        private System.Windows.Forms.Button btnAddEndereco;
        private System.Windows.Forms.FlowLayoutPanel flpEndereco;
        private System.Windows.Forms.FlowLayoutPanel flpContatos;
        private System.Windows.Forms.Button btnAddContatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbCalendar;
        private System.Windows.Forms.Label label1;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtCpf;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtDn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtRg;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtFiliacao1;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtFiliacao2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button btnExcluir;
    }
}