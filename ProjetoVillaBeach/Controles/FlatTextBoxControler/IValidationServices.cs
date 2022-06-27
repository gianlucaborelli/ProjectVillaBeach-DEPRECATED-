using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    interface IValidationServices
    {
        EnumValidationStatus IsValid { get; set; }
        void KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e);
        void Enter(object sender, EventArgs e);
        void Validating(object sender, System.ComponentModel.CancelEventArgs e);
        void Leave(object sender, EventArgs e);

    }
}
