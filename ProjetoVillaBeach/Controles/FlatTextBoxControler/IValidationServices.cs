using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    interface IValidationServices
    {
        /// <summary>
        /// Property that gets the maximum length for the TextBox.
        /// </summary>          
        int TextMaxLength { get; }

        /// <summary>
        /// Adds overload to the KeyPress event to handle pressed keys according to the selected document pattern.
        /// </summary>          
        void KeyPress(object sender, KeyPressEventArgs e);

        /// <summary>
        /// Attempts to validate the string according to the selected document pattern.
        /// </summary> 
        EnumValidationStatus TryToValidate(string value);

        /// <summary>
        /// Returns a masked string according to the selected document's pattern.
        /// </summary> 
        string CreateStringMasked(string value);

    }
}
