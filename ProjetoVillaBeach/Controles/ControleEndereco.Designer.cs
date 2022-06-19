namespace ProjetoVillaBeach.Controles
{
    partial class ControleEndereco
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
            this.txtCep = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtLocalidade = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cbUf = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCep
            // 
            this.txtCep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtCep.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCep.Location = new System.Drawing.Point(4, 4);
            this.txtCep.MaxLength = 10;
            this.txtCep.Name = "txtCep";
            this.txtCep.PlaceholderText = "C.E.P.";
            this.txtCep.Size = new System.Drawing.Size(99, 16);
            this.txtCep.TabIndex = 1;
            this.txtCep.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            this.txtCep.Leave += new System.EventHandler(this.Cep_Leave);
            this.txtCep.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.txtCep.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogradouro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLogradouro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogradouro.Location = new System.Drawing.Point(4, 4);
            this.txtLogradouro.MaxLength = 250;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.PlaceholderText = "Rua";
            this.txtLogradouro.Size = new System.Drawing.Size(445, 16);
            this.txtLogradouro.TabIndex = 2;
            this.txtLogradouro.Leave += new System.EventHandler(this.Logradouro_Leave);
            this.txtLogradouro.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.txtLogradouro.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // txtNumero
            // 
            this.txtNumero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Location = new System.Drawing.Point(4, 4);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PlaceholderText = "Número";
            this.txtNumero.Size = new System.Drawing.Size(109, 16);
            this.txtNumero.TabIndex = 3;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SomenteNumeros_KeyPress);
            this.txtNumero.Leave += new System.EventHandler(this.Numero_Leave);
            this.txtNumero.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.txtNumero.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBairro.Location = new System.Drawing.Point(4, 4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.PlaceholderText = "Bairro";
            this.txtBairro.Size = new System.Drawing.Size(211, 16);
            this.txtBairro.TabIndex = 4;
            this.txtBairro.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.txtBairro.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // txtLocalidade
            // 
            this.txtLocalidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocalidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLocalidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLocalidade.Location = new System.Drawing.Point(4, 4);
            this.txtLocalidade.Name = "txtLocalidade";
            this.txtLocalidade.PlaceholderText = "Cidade";
            this.txtLocalidade.Size = new System.Drawing.Size(211, 16);
            this.txtLocalidade.TabIndex = 4;
            this.txtLocalidade.Leave += new System.EventHandler(this.Localidade_Leave);
            this.txtLocalidade.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.txtLocalidade.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtObs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObs.Location = new System.Drawing.Point(5, 4);
            this.txtObs.MaxLength = 100;
            this.txtObs.Name = "txtObs";
            this.txtObs.PlaceholderText = "Observação";
            this.txtObs.Size = new System.Drawing.Size(575, 16);
            this.txtObs.TabIndex = 7;
            this.txtObs.Leave += new System.EventHandler(this.Obs_Leave);
            this.txtObs.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.txtObs.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // cbUf
            // 
            this.cbUf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.SetColumnSpan(this.cbUf, 2);
            this.cbUf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbUf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbUf.FormattingEnabled = true;
            this.cbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUf.Location = new System.Drawing.Point(471, 67);
            this.cbUf.Name = "cbUf";
            this.cbUf.Size = new System.Drawing.Size(115, 23);
            this.cbUf.TabIndex = 6;
            this.cbUf.Text = "Estado";
            this.cbUf.SelectionChangeCommitted += new System.EventHandler(this.Uf_Selection);
            this.cbUf.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.cbUf.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(40)))), ((int)(((byte)(32)))));
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(527, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(59, 24);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "X";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            this.btnExcluir.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.btnExcluir.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.txtCep);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 24);
            this.panel1.TabIndex = 8;
            this.panel1.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.panel1.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 9);
            this.panel2.Controls.Add(this.txtLogradouro);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(452, 24);
            this.panel2.TabIndex = 9;
            this.panel2.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.panel2.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel3, 12);
            this.panel3.Controls.Add(this.txtObs);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 23);
            this.panel3.TabIndex = 6;
            this.panel3.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.panel3.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel4, 2);
            this.panel4.Controls.Add(this.txtNumero);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(471, 35);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(115, 24);
            this.panel4.TabIndex = 10;
            this.panel4.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.panel4.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel5, 4);
            this.panel5.Controls.Add(this.txtLocalidade);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(237, 67);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(218, 25);
            this.panel5.TabIndex = 5;
            this.panel5.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.panel5.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableLayoutPanel1.SetColumnSpan(this.panel6, 4);
            this.panel6.Controls.Add(this.txtBairro);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 67);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 25);
            this.panel6.TabIndex = 10;
            this.panel6.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.panel6.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 12;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbUf, 10, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 10, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnExcluir, 11, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(589, 130);
            this.tableLayoutPanel1.TabIndex = 11;
            this.tableLayoutPanel1.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.tableLayoutPanel1.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            // 
            // ControleEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(0, 130);
            this.Name = "ControleEndereco";
            this.Size = new System.Drawing.Size(589, 130);
            this.MouseEnter += new System.EventHandler(this.Controle_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Controle_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCep;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtLocalidade;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ComboBox cbUf;
        public System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
