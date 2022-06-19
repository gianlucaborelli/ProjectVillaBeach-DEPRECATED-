using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Controles
{
    public partial class TextData : UserControl
    {
        [Category("Appearance")]
        [Description("The text displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public override string? Text
        {
            get
            {
                return txtData.Text;
            }
            set
            {
                InformaData(value);
            }
        }

        [Category("Appearance")]
        [Description("The text displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string PlaceholderText
        {
            get
            {

                return txtData.PlaceholderText;
            }
            set
            {
                txtData.PlaceholderText = value;
            }
        }

        public DateTime? DataSelecionada { get; private set; }

        public TextData()
        {
            InitializeComponent();
        }

        private void InformaData(string data)
        {
            
            if (!string.IsNullOrEmpty(data) || data != this.Name)
            {
                if (IsValidDate(data))
                {
                    data = TrataData(data);
                    DataSelecionada = DateTime.Parse(data);
                    txtData.Text = DataSelecionada.Value.ToString("dd/MM/yyyy");
                    pnlValido.BackColor = Color.DarkGreen;
                }
                else
                {
                    DataSelecionada = null;
                    pnlValido.BackColor = Color.Red;
                }
                
            }
            else
            {
                txtData.Text = string.Empty;
                DataSelecionada = null;
                pnlValido.BackColor = Color.Red;
            }
        }

        private void Data_Leave(object sender, EventArgs e)
        {
            InformaData(txtData.Text);
        }

        private void Data_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private static bool IsValidDate(string Data)
        {
            if (!string.IsNullOrEmpty(Data))
            {
                //DateTime.TryParseExact(Data, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out var valor);
                
                if (DateTime.TryParse(Data, new CultureInfo("pt-BR"), DateTimeStyles.None, out var data))
                {
                    return true;
                }
            }
            return false;
        }

        private static string TrataData(string data)
        {
            if (data.Length >= 8)
            {
                data = data.Trim();
                data = data.Replace("/", "");
                data = data.Insert(2, "/");
                data = data.Insert(5, "/");
            }            
            return data;
        }
    }
}
