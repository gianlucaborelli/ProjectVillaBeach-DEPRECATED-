using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    internal class UndefinedtextValidationServices : IValidationServices
    {
        public int TextMaxLength
        {
            get { return _textMinLength; }
        }
        public int _textMinLength = 250;

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
            if (!string.IsNullOrEmpty(value))
            {
                return EnumValidationStatus.Valid;
            }

            return EnumValidationStatus.NotChangedOrEmpty;
        }
    }
}
