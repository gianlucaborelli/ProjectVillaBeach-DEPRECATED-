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
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                OnImageChanging();
                pbImageCaptured.Image = value;
                OnImageChanged();
            }
        }

        #region Event ImageChanged
        public delegate void ImageChangedEventHandler(object sender, EventArgs args);

        public event ImageChangedEventHandler ImageChanged;

        protected virtual void OnImageChanged()
        {
            if (ImageChanged != null)
                ImageChanged(this, EventArgs.Empty);
        }
        #endregion

        #region Event ImageChanging
        public delegate void ImageChangingEventHandler(object sender, EventArgs args);

        public event ImageChangedEventHandler ImageChanging;

        protected virtual void OnImageChanging()
        {
            if (ImageChanging != null)
                ImageChanging(this, EventArgs.Empty);
        }
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
                OnImageChanging();
                pbImageCaptured.Image = frm.image;
                OnImageChanged();
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
                    OnImageChanging();
                    pbImageCaptured.Image = new Bitmap(openImagemFileDialog.FileName);
                    OnImageChanged();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
