using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    [DefaultEvent("_TextChanged")]
    [DefaultBindingProperty("Text")]
    public partial class FlatTextBox : UserControl, IValidationType, INotifyPropertyChanged
    {
        #region Custom Property 

        #region Text Property
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
        #endregion

        #region PlaceholderText Property
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
        #endregion

        #region BackColor Property
        [Category("Appearance")]
        [Description("A Color that represents the background color of the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        [DefaultValue(typeof(Color), "Control")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                txtBox.BackColor = value;
            }
        }
        #endregion

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                txtBox.ForeColor = value;
            }
        }

        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                txtBox.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        #region UnderlinedStyle
        [Category("Design")]
        [Description("Gets or sets the board's style displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        private bool underlinedStyle = true;
        #endregion

        #region BorderColor
        [Category("Design")]
        [Description("Gets or sets the border color displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        private Color borderColor = Color.MediumSlateBlue;
        #endregion

        #region Border Size
        [Category("Design")]
        [Description("Gets or sets the border thickness displayed by the control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get
            {
                return _borderSize;
            }
            set
            {
                _borderSize = value;
                this.Invalidate();
            }
        }
        private int _borderSize = 2;
        #endregion

        #region ValidationType Property
        [Category("Validation")]
        [Description("A Validator Type that represents how the control will be validated.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

        #region ValidationStatus 
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
                OnPropertyChanged();
            }
        }
        private EnumValidationStatus _status;
        #endregion

        #region Password Char
        [Category("Design")]
        [Description("Gets or sets the character used to mask characters of a password in a TextBox control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool PasswordChar
        {
            get
            {
                return txtBox.UseSystemPasswordChar;
            }
            set
            {
                txtBox.UseSystemPasswordChar = value;
            }
        }
        #endregion

        #region Multiline
        [Category("Design")]
        [Description("Gets or sets a value indicating whether this is a multiline TextBox control.")]
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool Multiline
        {
            get
            {
                return txtBox.Multiline;
            }
            set
            {
                txtBox.Multiline = value;
            }
        }
        #endregion

        #region Requered Property
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

        public bool RequiredMet = true;

        #endregion

        #region RequirementsAreSatisfied Property
        public bool RequirementsAreSatisfied
        {
            get
            {
                return _requirementsAreSatisfied;
            }
            set
            {
                _requirementsAreSatisfied = value;
            }
        }
        private bool _requirementsAreSatisfied;
        #endregion

        #endregion

        #region Custom Method
        public void Clear()
        {
            txtBox.Clear();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using Pen penBorder = new(borderColor, _borderSize);

            penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

            if (underlinedStyle)
                graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
            else
                graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void TextBox_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void TextBox_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void KeyPress_Event(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);

            _services.KeyPress(sender, e);
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
            ValidateTextBox();

            txtBox.SelectionStart = txtBox.Text.Length;
        }

        private void OnLoad_Event(object sender, EventArgs e)
        {
            _services = ValidationFactory.GetValidator(_type);
            PropertyChanged += PropertyChanged_Method;
            txtBox.MaxLength = _services.TextMaxLength;

            if (_required == true)
            {
                RequiredMet = false;
            }
        }

        private void Leave_Event(object sender, EventArgs e)
        {
            base.OnLeave(e);
            
            ValidateTextBox();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            base.OnEnter(e);
        }

        #endregion

        #region Custom Events

        #region TextChanged
        public event EventHandler? _TextChanged;

        private void FlatTextBox_TextChanged(object sender, EventArgs e)
        {
            this.OnTextChanged(e);
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }
        #endregion

        #region INotifyPropertyChanged 

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void PropertyChanged_Method(object sender, PropertyChangedEventArgs e)
        {
            switch (_status)
            {
                case EnumValidationStatus.Valid:
                    BorderColor = Color.DarkGreen;
                    break;
                case EnumValidationStatus.Invalid:
                    BorderColor = Color.DarkRed;
                    break;
                default:
                    BorderColor = Color.DarkBlue;
                    break;
            }

            this.Invalidate();
        }
        #endregion

        #endregion

        #region IsRequered Implementation

        public bool RequirementsSatisfied(string value, out string errorMessage)
        {
            if (value.Length == 0 && _required == true)
            {
                errorMessage = _services.ToString() + " é de preenchimento obrigatório.";
                RequiredMet = false;
                return false;
            }

            errorMessage = "";
            RequiredMet = false;

            return true;
        }

        private void ValidatingTxtBox_Event(object sender, CancelEventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox)
                {
                    c.Dispose();
                }
            }

            if (!RequirementsSatisfied(txtBox.Text, out string errorMsg))
            {
                PictureBox pbErros = new();

                ToolTip tt = new();
                tt.SetToolTip(pbErros, errorMsg);
                tt.ShowAlways = true;

                pbErros.Image = Image.FromFile(@"D:\Projetos\ProjetoVillaBeach\ProjetoVillaBeach\Pictures\ErrorPic.png");
                pbErros.Size = pbErros.Image.Size;
                pbErros.Location = new Point(this.Width - pbErros.Image.Width, 6);
                pbErros.BackColor = Color.Transparent;

                this.Controls.Add(pbErros);
                pbErros.BringToFront();
            }
        }
        #endregion

        public FlatTextBox()
        {
            InitializeComponent();
        }
        private IValidationServices? _services = null;

        private void UpdateControlHeight()
        {
            if (txtBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                txtBox.Multiline = true;
                txtBox.MinimumSize = new Size(0, txtHeight);
                txtBox.Multiline = false;
                this.Height = txtBox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void ValidateTextBox()
        {
            ValidationStatus = _services.TryToValidate(txtBox.Text);

            txtBox.Text = _services.CreateStringMasked(txtBox.Text);
        }

        public ulong ToUlongParse()
        {
            string stg = txtBox.Text;

            stg = stg.Trim();
            stg = stg.Replace(".", "").Replace("-", "").Replace("/", "");

            ulong.TryParse(stg, out ulong value);

            return value;
        }

        private bool CompleteSatisfactionRequirements()
        {
            return false;
        }
    }
}
