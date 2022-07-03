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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbDadosPessoais = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flatTxtNome = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.pbCalendar = new System.Windows.Forms.PictureBox();
            this.tbContatos = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flpContatos = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddEndereco = new System.Windows.Forms.Button();
            this.flpEndereco = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddContatos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.flatTxtCpf = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.flatTxtDn = new ProjetoVillaBeach.Controles.FlatTextBoxControler.FlatTextBox();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbDadosPessoais.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendar)).BeginInit();
            this.tbContatos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSalvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 710);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1220, 110);
            this.panel2.TabIndex = 1;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
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
            this.tableLayoutPanel2.ColumnCount = 12;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel2.Controls.Add(this.flatTxtNome, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pbCalendar, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtCpf, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.flatTxtDn, 9, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1182, 553);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // flatTxtNome
            // 
            this.flatTxtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flatTxtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel2.SetColumnSpan(this.flatTxtNome, 5);
            this.flatTxtNome.Location = new System.Drawing.Point(4, 4);
            this.flatTxtNome.Margin = new System.Windows.Forms.Padding(4);
            this.flatTxtNome.Name = "flatTxtNome";
            this.flatTxtNome.PlaceholderText = "Nome";
            this.flatTxtNome.Required = true;
            this.flatTxtNome.RequirementsAreSatisfied = false;
            this.flatTxtNome.Size = new System.Drawing.Size(612, 34);
            this.flatTxtNome.TabIndex = 0;
            this.flatTxtNome.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtNome.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.UndefinedText;
            this.flatTxtNome.Leave += new System.EventHandler(this.textNome1_Leave);
            // 
            // pbCalendar
            // 
            this.pbCalendar.Image = global::ProjetoVillaBeach.Properties.Resources.Calendar_48px;
            this.pbCalendar.Location = new System.Drawing.Point(1149, 3);
            this.pbCalendar.Name = "pbCalendar";
            this.pbCalendar.Size = new System.Drawing.Size(30, 35);
            this.pbCalendar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCalendar.TabIndex = 3;
            this.pbCalendar.TabStop = false;
            this.pbCalendar.Click += new System.EventHandler(this.Calendar_Click);
            // 
            // tbContatos
            // 
            this.tbContatos.AutoScroll = true;
            this.tbContatos.Controls.Add(this.tableLayoutPanel1);
            this.tbContatos.Location = new System.Drawing.Point(4, 30);
            this.tbContatos.Name = "tbContatos";
            this.tbContatos.Padding = new System.Windows.Forms.Padding(3);
            this.tbContatos.Size = new System.Drawing.Size(1188, 559);
            this.tbContatos.TabIndex = 1;
            this.tbContatos.Text = "Contatos";
            this.tbContatos.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.flpContatos, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddEndereco, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpEndereco, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnAddContatos, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1176, 547);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // flpContatos
            // 
            this.flpContatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpContatos.AutoScroll = true;
            this.flpContatos.AutoSize = true;
            this.flpContatos.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpContatos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flpContatos.Location = new System.Drawing.Point(601, 73);
            this.flpContatos.Name = "flpContatos";
            this.tableLayoutPanel1.SetRowSpan(this.flpContatos, 2);
            this.flpContatos.Size = new System.Drawing.Size(572, 471);
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
            this.btnAddEndereco.Size = new System.Drawing.Size(204, 44);
            this.btnAddEndereco.TabIndex = 6;
            this.btnAddEndereco.Text = "Adicionar Endereço";
            this.btnAddEndereco.UseVisualStyleBackColor = false;
            this.btnAddEndereco.Click += new System.EventHandler(this.BtnAddEndereco_Click);
            // 
            // flpEndereco
            // 
            this.flpEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpEndereco.AutoScroll = true;
            this.flpEndereco.AutoSize = true;
            this.flpEndereco.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpEndereco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flpEndereco.Location = new System.Drawing.Point(3, 73);
            this.flpEndereco.Name = "flpEndereco";
            this.tableLayoutPanel1.SetRowSpan(this.flpEndereco, 2);
            this.flpEndereco.Size = new System.Drawing.Size(572, 471);
            this.flpEndereco.TabIndex = 5;
            this.flpEndereco.WrapContents = false;
            // 
            // btnAddContatos
            // 
            this.btnAddContatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(160)))), ((int)(((byte)(200)))));
            this.btnAddContatos.FlatAppearance.BorderSize = 0;
            this.btnAddContatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContatos.Location = new System.Drawing.Point(601, 3);
            this.btnAddContatos.Name = "btnAddContatos";
            this.btnAddContatos.Size = new System.Drawing.Size(204, 44);
            this.btnAddContatos.TabIndex = 7;
            this.btnAddContatos.Text = "Adicionar Contato";
            this.btnAddContatos.UseVisualStyleBackColor = false;
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
            // flatTxtCpf
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flatTxtCpf, 2);
            this.flatTxtCpf.Location = new System.Drawing.Point(639, 4);
            this.flatTxtCpf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flatTxtCpf.Name = "flatTxtCpf";
            this.flatTxtCpf.PlaceholderText = "C.P.F.";
            this.flatTxtCpf.Required = false;
            this.flatTxtCpf.RequirementsAreSatisfied = false;
            this.flatTxtCpf.Size = new System.Drawing.Size(240, 33);
            this.flatTxtCpf.TabIndex = 4;
            this.flatTxtCpf.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtCpf.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.CPF;
            // 
            // flatTxtDn
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.flatTxtDn, 2);
            this.flatTxtDn.Location = new System.Drawing.Point(902, 4);
            this.flatTxtDn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flatTxtDn.Name = "flatTxtDn";
            this.flatTxtDn.PlaceholderText = "Data de Nascimento";
            this.flatTxtDn.Required = false;
            this.flatTxtDn.RequirementsAreSatisfied = false;
            this.flatTxtDn.Size = new System.Drawing.Size(240, 33);
            this.flatTxtDn.TabIndex = 5;
            this.flatTxtDn.ValidationStatus = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationStatus.NotChangedOrEmpty;
            this.flatTxtDn.ValidationType = ProjetoVillaBeach.Controles.FlatTextBoxControler.EnumValidationType.Date;
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
            ((System.ComponentModel.ISupportInitialize)(this.pbCalendar)).EndInit();
            this.tbContatos.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flpContatos;
        private System.Windows.Forms.Button btnAddContatos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pbCalendar;
        private System.Windows.Forms.Label label1;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtCpf;
        private Controles.FlatTextBoxControler.FlatTextBox flatTxtDn;
    }
}