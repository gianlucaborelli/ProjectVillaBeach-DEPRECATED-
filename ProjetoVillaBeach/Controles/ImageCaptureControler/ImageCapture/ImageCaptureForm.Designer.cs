namespace ProjetoVillaBeach.Controles.ImageCaptureControler
{
    partial class ImageCaptureForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbWebCam = new System.Windows.Forms.PictureBox();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pbCaptura = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pbClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 48);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(56, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Captura de Imagem";
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Image = global::ProjetoVillaBeach.Properties.Resources.icons8_close_32px;
            this.pbClose.Location = new System.Drawing.Point(816, 0);
            this.pbClose.Margin = new System.Windows.Forms.Padding(5);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(55, 48);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbClose.TabIndex = 2;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbWebCam
            // 
            this.pbWebCam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWebCam.Location = new System.Drawing.Point(14, 60);
            this.pbWebCam.Margin = new System.Windows.Forms.Padding(4);
            this.pbWebCam.Name = "pbWebCam";
            this.pbWebCam.Size = new System.Drawing.Size(400, 400);
            this.pbWebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbWebCam.TabIndex = 1;
            this.pbWebCam.TabStop = false;
            // 
            // btnCapturar
            // 
            this.btnCapturar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCapturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCapturar.Image = global::ProjetoVillaBeach.Properties.Resources.icons8_keyshot_32px_1;
            this.btnCapturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapturar.Location = new System.Drawing.Point(127, 471);
            this.btnCapturar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Padding = new System.Windows.Forms.Padding(20, 0, 25, 0);
            this.btnCapturar.Size = new System.Drawing.Size(174, 50);
            this.btnCapturar.TabIndex = 3;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapturar.UseVisualStyleBackColor = false;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.DarkGray;
            this.btnSalvar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalvar.Image = global::ProjetoVillaBeach.Properties.Resources.icons8_save_32px;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(570, 471);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Padding = new System.Windows.Forms.Padding(20, 0, 35, 0);
            this.btnSalvar.Size = new System.Drawing.Size(174, 50);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pbCaptura
            // 
            this.pbCaptura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCaptura.Location = new System.Drawing.Point(457, 60);
            this.pbCaptura.Margin = new System.Windows.Forms.Padding(4);
            this.pbCaptura.Name = "pbCaptura";
            this.pbCaptura.Size = new System.Drawing.Size(400, 400);
            this.pbCaptura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCaptura.TabIndex = 5;
            this.pbCaptura.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjetoVillaBeach.Properties.Resources.icons8_camera_35px;
            this.pictureBox1.Location = new System.Drawing.Point(10, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 30);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ImageCaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(871, 533);
            this.Controls.Add(this.pbCaptura);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.pbWebCam);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImageCaptureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCapturaDeImagem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCapturaDeImagem_FormClosing);
            this.Load += new System.EventHandler(this.FormCapturaDeImagem_Load);
            this.Shown += new System.EventHandler(this.FormCapturaDeImagem_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWebCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbWebCam;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pbCaptura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}