using ProjetoVillaBeach.Classes.Documents;
using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    internal class DateValidationServices : IValidationServices
    {
        public int TextMaxLength
        {
            get { return _textMinLength; }
        }
        public int _textMinLength = 10;

        public string CreateStringMasked(string value)
        {
            value = value.Trim();
            value = value.Replace(".", "").Replace("-", "").Replace("/", "");


            if (value.Length >= 3 && value.Length < 5)
            {
                value = value.Insert(2, "/");
            }
            else if (value.Length >= 5)
            {
                value = value.Insert(2, "/");
                value = value.Insert(5, "/");
            }

            return value;
        }

        public void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public EnumValidationStatus TryToValidate(string value)
        {
            if (Date.IsDate(value))
            {
                return EnumValidationStatus.Valid;
            }
            else if (!Date.IsDate(value) && !string.IsNullOrEmpty(value))
            {
                return EnumValidationStatus.Invalid;
            }

            return EnumValidationStatus.NotChangedOrEmpty;
        }

        public override string ToString()
        {
            return "Data";
        }
    }
}
