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
using System.Threading.Channels;

namespace ProjetoVillaBeach.Controles.ImageCaptureControler
{
    [DefaultEvent("ImageChanged")]
    [DefaultBindingProperty("Captured")]
    public partial class ImageCapture : UserControl
    {
        private OpenFileDialog openImagemFileDialog;

        [Category("Appearance")]
        [Description("The Image displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public Image? Captured
        {
            get
            {
                return pbImageCaptured.Image;
            }
            set
            {
                ImageChangingArgs args = new();

                ImageChanging?.Invoke(this, args);

                if (!args.Cancel)
                {
                    pbImageCaptured.Image.Dispose();

                    pbImageCaptured.Image = value;

                    ImageChanged?.Invoke(this);
                }
            }
        }

        #region Event ImageChanged
        public delegate void ImageChangedEventHandler(object sender);

        public event ImageChangedEventHandler? ImageChanged;
        
        #endregion

        #region Event ImageChanging
        public delegate void ImageChangingEventHandler(object sender, ImageChangingArgs args);
                
        public event EventHandler<ImageChangingArgs>? ImageChanging;

        #endregion

        #region Event ImageDelete
        public delegate void ImageDeletingEventHandler(object sender, EventArgs args);

        public event EventHandler<ImageDeletingArgs>? ImageDeleting;

        #endregion

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
                pbImageCaptured.Image = frm.image;
            }
        }

        private void PictureBox_SizeChanged(object sender, EventArgs e)
        {
            this.OnSizeChanged(e);
                        
            UpdateControlHeight();
        }

        private void OpenImagemFile_Click(object sender, EventArgs e)
        {
            openImagemFileDialog = new()
            {
                FileName = "Selecione uma imagem",
                Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.gif;*.tif;...",
                Title = "Pesquise uma imagem",
                InitialDirectory = @"C:\"
            };

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

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ImageDeleting?.Invoke(this, new ImageDeletingArgs());
        }
    }
}
