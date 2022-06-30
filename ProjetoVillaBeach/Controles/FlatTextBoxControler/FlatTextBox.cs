using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public EnumValidationStatus ValidationStatus
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
                OnPropertyChanged("ValidationStatus");
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
        
        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void PropertyChanged_Method(object sender, PropertyChangedEventArgs e)
        {
            switch (_status)
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
        }
        private IValidationServices _services = null;

        private void OnLoad_Event(object sender, EventArgs e)
        {
            _services = ValidationFactory.GetValidator(_type);
            this.PropertyChanged += PropertyChanged_Method;
            txtBox.MaxLength = _services.TextMaxLength;
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
            txtBox.BackColor = _backColor;
        }

        private void ValidateTextBox()
        {
            if (!string.IsNullOrEmpty(txtBox.Text))
            {
                if (_services.TryToValidate(txtBox.Text))
                {
                    this.ValidationStatus = EnumValidationStatus.Valid;
                }
                else
                {
                    this.ValidationStatus = EnumValidationStatus.Invalid;
                }
            }
            else
            {
                this.ValidationStatus = EnumValidationStatus.NotChanged;
            }

            txtBox.Text = _services.CreateStringMasked(txtBox.Text);
        }

        private void Leave_Event(object sender, EventArgs e)
        {
            ValidateTextBox();
        }

        private void txtBox_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateTextBox();
            
            txtBox.SelectionStart = txtBox.Text.Length;
        }

        private void Enter_Event(object sender, EventArgs e)
        {
            
        }

        private void KeyPress_Event(object sender, KeyPressEventArgs e)
        {
            _services.KeyPress(sender, e);
        }
    }
}
