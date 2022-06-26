using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    public partial class FlatTextBox : UserControl, IValidationType
    {
        #region Custom Property 

        [Category("Appearance")]
        [Description("The text displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return txtNome.Text;
            }
            set
            {
                txtNome.Text = value;
            }
        }

        [Category("Appearance")]
        [Description("The text that is displayed when the control has no text and does not have the focus.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public string PlaceholderText
        {
            get
            {

                return txtNome.PlaceholderText;
            }
            set
            {
                txtNome.PlaceholderText = value;
            }
        }

        [Category("Appearance")]
        [Description("A Color that represents the background color of the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [DefaultValue(typeof(Color), "Control")]
        public new Color BackColor
        {
            get
            {
                return _backColor;
            }
            set
            {
                _backColor = value;
            }
        }
        private Color _backColor;

        [Category("Validation")]
        [Description("A Validator Type that represents how the control will be validated.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [DefaultValue(typeof(EnumValidationType), "UndefinedText")]
        public EnumValidationType ValidationType
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        private EnumValidationType _type;

        #endregion

        IValidationServices _services = null;
        public FlatTextBox()
        {
            InitializeComponent();

            _services = ValidationFactory.getValidator(_type);
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var method = typeof(Control).GetMethod("PaintBackground",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                new Type[] { typeof(PaintEventArgs), typeof(Rectangle), typeof(Color) },
                null);

            method.Invoke(this, new object[] { e, ClientRectangle, _backColor });
            txtNome.BackColor = _backColor;
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {            
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                
            }
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            if (txtNome.Text == "Nome")
            {
                txtNome.Text = string.Empty;
                txtNome.ForeColor = Color.Black;
            }
        }

        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                pnlValido.BackColor = Color.Red;
            }
            else
            {
                pnlValido.BackColor = Color.DarkGreen;
            }
        }
    }
}
