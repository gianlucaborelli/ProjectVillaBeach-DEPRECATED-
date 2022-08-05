namespace ProjetoVillaBeach.Controles.ImageCaptureControler
{
    partial class ImageCapture
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
            this.btnOpenImageFile = new System.Windows.Forms.Button();
            this.btnOpenCaptureImage = new System.Windows.Forms.Button();
            this.btnClearImageCaptured = new System.Windows.Forms.Button();
            this.pbImageCaptured = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageCaptured)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenImageFile
            // 
            this.btnOpenImageFile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOpenImageFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenImageFile.FlatAppearance.BorderSize = 0;
            this.btnOpenImageFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenImageFile.Image = global::ProjetoVillaBeach.Properties.Resources.icons8_Browse_Folder_32px_1;
            this.btnOpenImageFile.Location = new System.Drawing.Point(7, 218);
            this.btnOpenImageFile.Name = "btnOpenImageFile";
            this.btnOpenImageFile.Size = new System.Drawing.Size(34, 34);
            this.btnOpenImageFile.TabIndex = 0;
            this.btnOpenImageFile.UseVisualStyleBackColor = false;
            this.btnOpenImageFile.Click += new System.EventHandler(this.OpenImagemFile_Click);
            // 
            // btnOpenCaptureImage
            // 
            this.btnOpenCaptureImage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnOpenCaptureImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenCaptureImage.FlatAppearance.BorderSize = 0;
            this.btnOpenCaptureImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenCaptureImage.Image = global::ProjetoVillaBeach.Properties.Resources.icons8_camera_32px_1;
            this.btnOpenCaptureImage.Location = new System.Drawing.Point(180, 218);
            this.btnOpenCaptureImage.Name = "btnOpenCaptureImage";
            this.btnOpenCaptureImage.Size = new System.Drawing.Size(34, 34);
            this.btnOpenCaptureImage.TabIndex = 1;
            this.btnOpenCaptureImage.UseVisualStyleBackColor = false;
            this.btnOpenCaptureImage.Click += new System.EventHandler(this.OpenCaptureImage_Click);
            // 
            // btnClearImageCaptured
            // 
            this.btnClearImageCaptured.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnClearImageCaptured.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearImageCaptured.FlatAppearance.BorderSize = 0;
            this.btnClearImageCaptured.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearImageCaptured.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearImageCaptured.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnClearImageCaptured.Location = new System.Drawing.Point(51, 218);
            this.btnClearImageCaptured.Name = "btnClearImageCaptured";
            this.btnClearImageCaptured.Size = new System.Drawing.Size(119, 34);
            this.btnClearImageCaptured.TabIndex = 2;
            this.btnClearImageCaptured.Text = "Limpar";
            this.btnClearImageCaptured.UseVisualStyleBackColor = false;
            // 
            // pbImageCaptured
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pbImageCaptured, 5);
            this.pbImageCaptured.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbImageCaptured.Location = new System.Drawing.Point(7, 7);
            this.pbImageCaptured.Name = "pbImageCaptured";
            this.pbImageCaptured.Size = new System.Drawing.Size(207, 201);
            this.pbImageCaptured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageCaptured.TabIndex = 3;
            this.pbImageCaptured.TabStop = false;
            this.pbImageCaptured.SizeChanged += new System.EventHandler(this.PictureBox_SizeChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.Controls.Add(this.pbImageCaptured, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenCaptureImage, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnClearImageCaptured, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenImageFile, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(221, 259);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ImageCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ImageCapture";
            this.Size = new System.Drawing.Size(221, 259);
            ((System.ComponentModel.ISupportInitialize)(this.pbImageCaptured)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenImageFile;
        private System.Windows.Forms.Button btnOpenCaptureImage;
        private System.Windows.Forms.Button btnClearImageCaptured;
        private System.Windows.Forms.PictureBox pbImageCaptured;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
