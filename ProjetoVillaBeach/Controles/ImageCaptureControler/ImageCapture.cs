using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Diagnostics;
using System.IO;

namespace ProjetoVillaBeach.Controles.ImageCaptureControler
{
    public partial class ImageCapture : UserControl
    {
        private OpenFileDialog openImagemFileDialog;

        public ImageCapture()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (pbImageCaptured.Width == pbImageCaptured.Height) return;

            // Keep Acpect Ratio
            const double factor = 1.22897196262;


            if (pbImageCaptured.Width > pbImageCaptured.Height)
            {
                this.Height = (int)(this.Width * factor);
            }
            else
            {
                this.Width = (int)(this.Height / factor);
            }
        }

        private void OpenCaptureImage_Click(object sender, EventArgs e)
        {
            ImageCaptureForm frm = new();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                //funcionario.InformaFoto(frm.image);
                //pbFuncionario.Image = funcionario.Foto;
            }
        }

        private void PictureBox_SizeChanged(object sender, EventArgs e)
        {
            this.OnSizeChanged(e);
                        
            UpdateControlHeight();
        }

        private void OpenImagemFile_Click(object sender, EventArgs e)
        {
            openImagemFileDialog = new();
            openImagemFileDialog.FileName = "Selecione uma imagem";
            openImagemFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            openImagemFileDialog.Title = "Pesquise uma imagem";
            openImagemFileDialog.InitialDirectory = @"C:\";

            if (openImagemFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbImageCaptured.Image = new Bitmap(openImagemFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
