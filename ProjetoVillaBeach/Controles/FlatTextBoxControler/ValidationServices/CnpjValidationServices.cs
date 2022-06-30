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
            throw new NotImplementedException();
        }

        public void KeyPress(object sender, KeyPressEventArgs e)
        {
            throw new NotImplementedException();
        }

        public bool TryToValidate(string value)
        {
            throw new NotImplementedException();
        }
    }
}
