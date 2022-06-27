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
    public partial class FlatTextBox : UserControl, IValidationType, INotifyPropertyChanged
    {
        #region Custom Property 

        [Category("Appearance")]
        [Description("The text displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string? Text
        {
            get
            {
                return txtBox.Text;
            }
            set
            {
                txtBox.Text = value;
                OnPropertyChanged();
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
                return txtBox.PlaceholderText;
            }
            set
            {
                txtBox.PlaceholderText = value;
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

        [Category("Validation")]
        [Description("Displays the component's validation status.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [DefaultValue(typeof(EnumValidationType), "UndefinedText")]
        public EnumValidationStatus ValidationStatus
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }
        private EnumValidationStatus _status;

        [Category("Validation")]
        [Description("Specifies that a data field value is required.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public bool Required
        {
            get
            {
                return _required;
            }
            set
            {
                _required = value;
            }
        }
        private bool _required;

        #endregion

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;        
        
        protected void OnPropertyChanged(string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private void PropertyChanged_Method(object sender, PropertyChangedEventArgs e)
        {
            switch (_services.IsValid)
            {
                case EnumValidationStatus.Valid:
                    pnlValido.BackColor = Color.DarkGreen;
                    break;
                case EnumValidationStatus.Invalid:
                    pnlValido.BackColor = Color.DarkRed;
                    break;
                default:
                    pnlValido.BackColor = Color.DarkBlue;
                    break;
            }
        }
        #endregion
                
        public FlatTextBox()
        {
            InitializeComponent();

            this.PropertyChanged += PropertyChanged_Method;

            _services = ValidationFactory.GetValidator(_type);
        }
        private IValidationServices _services = null;

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            var method = typeof(Control).GetMethod("PaintBackground",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                new Type[] { typeof(PaintEventArgs), typeof(Rectangle), typeof(Color) },
                null);

            method.Invoke(this, new object[] { e, ClientRectangle, _backColor });
            txtBox.BackColor = _backColor;
        }

        private void Leave_Event(object sender, EventArgs e)
        {            
            
        }

        private void Enter_Event(object sender, EventArgs e)
        {
            
        }

        private void Validating_Event(object sender, CancelEventArgs e)
        {
            
        }

        private void KeyPress_Event(object sender, KeyPressEventArgs e)
        {

        }
    }
}
