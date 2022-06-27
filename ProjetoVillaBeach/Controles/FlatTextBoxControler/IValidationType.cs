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
        CNPJ,
        PIS,
        Date,
        EMail        
    }
    public enum EnumValidationStatus
    {
        NotChanged,
        Valid,
        Invalid
    }

    interface IValidationType
    {
        public EnumValidationType ValidationType { get; set; }
        public EnumValidationStatus ValidationStatus { get; set; }
    }
}
