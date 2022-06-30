using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    internal class DateValidationServices: IValidationServices
    {
        public int TextMaxLength
        {
            get { return _textMinLength; }
        }
        public int _textMinLength = 14;

        /// <summary>
        /// Validates if the number entered is a Date
        /// </summary>
        public static bool IsDate(string date)
        {
            DateTime valor;

            date = date.Trim();
            date = date.Replace(".", "").Replace("-", "").Replace("/", "");

            var converted = DateTime
                .TryParseExact(date,
                                "dd/MM/yyyy",
                                CultureInfo.InvariantCulture,
                                DateTimeStyles.None,
                                out valor);

            return converted;
        }

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
