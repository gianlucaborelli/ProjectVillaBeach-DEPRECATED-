using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    public enum EnumValidationType
    {
        UndefinedText,
        CPF,
        Date,
        EMail,
        Unchanged
    }

    interface IValidationType
    {
        public EnumValidationType ValidationType { get; set; }
    }
}
