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

namespace ProjetoVillaBeach.Controles.ImageCaptureControler
{
    public partial class ImageCapture : UserControl
    {
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
    }
}
