using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    /// <summary>
    /// Validation Type Set.
    /// </summary>
    public enum EnumValidationType
    {
        UndefinedText,
        CPF,
        CNPJ,
        PIS,
        Date,
        EMail        
    }

    /// <summary>
    /// Validation Status Type Set.
    /// </summary>
    public enum EnumValidationStatus
    {
        /// <summary>
        /// Not valid or empty.
        /// </summary>
        NotChangedOrEmpty,
        /// <summary>
        /// Value is valid.
        /// </summary>
        Valid,
        /// <summary>
        /// Value is not valid.
        /// </summary>
        Invalid
    }

    interface IValidationType
    {
        public EnumValidationType ValidationType { get; set; }
        public EnumValidationStatus ValidationStatus { get; set; }
    }
}
