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
    internal class CnpjValidationServices : IValidationServices
    {
        public int TextMaxLength
        {
            get { return _textMinLength; }
        }
        public int _textMinLength = 18;        

        public string CreateStringMasked(string value)
        {
            value = value.Trim();
            value = value.Replace(".", "").Replace("-", "").Replace("/", "");


            if (value.Length >= 3 && value.Length < 6)
            {
                value = value.Insert(2, ".");
            }
            else if (value.Length >= 6 && value.Length < 8)
            {
                value = value.Insert(2, ".");
                value = value.Insert(6, ".");
            }
            else if (value.Length >= 9 && value.Length < 12)
            {
                value = value.Insert(2, ".");
                value = value.Insert(6, ".");
                value = value.Insert(10, "/");
            }
            else if (value.Length >= 13)
            {
                value = value.Insert(2, ".");
                value = value.Insert(6, ".");
                value = value.Insert(10, "/");
                value = value.Insert(15, "-");
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
            if (Cnpj.IsCNPJ(value))
            {
                return EnumValidationStatus.Valid;
            }
            else if (!Cnpj.IsCNPJ(value) && !string.IsNullOrEmpty(value))
            {
                return EnumValidationStatus.Invalid;
            }

            return EnumValidationStatus.NotChangedOrEmpty;
        }

        public override string ToString()
        {
            return "C.N.P.J.";
        }

        public bool ReturnValue<T>(string input, out T value)
        {
            throw new NotImplementedException();
        }
    }
}
