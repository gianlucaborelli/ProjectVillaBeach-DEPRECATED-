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
    internal class PisValidationServices : IValidationServices
    {
        public int TextMaxLength
        {
            get { return _textMinLength; }
        }
        public int _textMinLength = 14;

        public string CreateStringMasked(string value)
        {
            value = value.Trim();
            value = value.Replace(".", "").Replace("-", "");


            if (value.Length >= 4 && value.Length < 8)
            {
                value = value.Insert(3, ".");
            }
            else if (value.Length >= 9 && value.Length < 11)
            {
                value = value.Insert(3, ".");
                value = value.Insert(9, ".");
            }
            else if (value.Length >= 11)
            {
                value = value.Insert(3, ".");
                value = value.Insert(9, ".");
                value = value.Insert(12, "-");
            }
            
            //value = value.Replace(/ ^(\d{ 3})(\d)/, "$1.$2");                        //Coloca ponto entre o terceiro e o quarto dígitos
            //value = value.Replace(/ ^(\d{ 3})\.(\d{ 5})(\d)/, "$1.$2.$3");            //Coloca ponto entre o quinto e o sexto dígitos
            //value = value.Replace(/ (\d{ 3})\.(\d{ 5})\.(\d{ 2})(\d)/, "$1.$2.$3.$4"); //Coloca ponto entre o décimo e o décimo primeiro dígitos
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
            if (Pis.IsPis(value))
            {
                return EnumValidationStatus.Valid;
            }
            else if (!Pis.IsPis(value) && !string.IsNullOrEmpty(value))
            {
                return EnumValidationStatus.Invalid;
            }

            return EnumValidationStatus.NotChangedOrEmpty;
        }

        public override string ToString()
        {
            return "P.I.S.";
        }
    }
}
