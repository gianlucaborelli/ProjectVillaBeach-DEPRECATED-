using ProjetoVillaBeach.Classes;
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
    internal class CpfValidationServices : IValidationServices
    {
        public int TextMaxLength
        {
            get { return _textMinLength; }
        }
        public int _textMinLength = 14;

        public void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        public EnumValidationStatus TryToValidate(string value)
        {
            if (Cpf.IsCpf(value))
            {
                return EnumValidationStatus.Valid;
            }
            else if (!Cpf.IsCpf(value) && !string.IsNullOrEmpty(value))
            {
                return EnumValidationStatus.Invalid;
            }

            return EnumValidationStatus.NotChangedOrEmpty;
        }

        public string CreateStringMasked(string value)
        {
            value = value.Trim();
            value = value.Replace(".", "").Replace("-", "");


            if (value.Length >= 4 && value.Length < 7)
            {
                value = value.Insert(3, ".");
            }
            else if (value.Length >= 7 && value.Length < 10)
            {
                value = value.Insert(3, ".");
                value = value.Insert(7, ".");
            }
            else if (value.Length >= 10)
            {
                value = value.Insert(3, ".");
                value = value.Insert(7, ".");
                value = value.Insert(11, "-");
            }

            return value;
        }

        public override string ToString()
        {
            return "C.P.F.";
        }

        public bool ReturnValue<T>(string input, out T value)
        {
            throw new NotImplementedException();
        }
    }
}
