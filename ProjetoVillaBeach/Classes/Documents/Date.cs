using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace ProjetoVillaBeach.Classes.Documents
{
    internal class Date
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
