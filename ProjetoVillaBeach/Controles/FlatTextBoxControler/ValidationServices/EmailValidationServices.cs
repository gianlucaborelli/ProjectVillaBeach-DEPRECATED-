using ProjetoVillaBeach.Classes.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    internal class EmailValidationServices : IValidationServices
    {
        public int TextMaxLength
        {
            get { return _textMinLength; }
        }
        public int _textMinLength = 14;

        public string CreateStringMasked(string value)
        {
            return value;
        }

        public void KeyPress(object sender, KeyPressEventArgs e)
        {
            //No Implementation Needed
        }

        public EnumValidationStatus TryToValidate(string value)
        {
            if (EmailType.IsValid(value))
            {
                return EnumValidationStatus.Valid;
            }
            else if (!EmailType.IsValid(value) && !string.IsNullOrEmpty(value))
            {
                return EnumValidationStatus.Invalid;
            }

            return EnumValidationStatus.NotChangedOrEmpty;
        }

        public override string ToString()
        {
            return "E-mail";
        }
    }
}
