using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    internal class DateValidationServices: IValidationServices
    {

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
    }
}
