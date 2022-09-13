using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Entities.Base
{
    public enum EnumStates
    {
        /// <summary>
        /// Acre.
        /// </summary>
        [Description("Acre")]
        AC,
        /// <summary>
        /// Alagoas.
        /// </summary>
        [Description("Alagoas")]
        AL,
        /// <summary>
        /// Amapá.
        /// </summary>
        [Description("Amapá")]
        AP,
        /// <summary>
        /// Amazonas.
        /// </summary>
        [Description("Amazonas")]
        AM,
        /// <summary>
        /// Bahia.
        /// </summary>
        [Description("Bahia")]
        BA,
        /// <summary>
        /// Ceará.
        /// </summary>
        [Description("Ceará")]
        CE,
        /// <summary>
        /// Distrito Federal.
        /// </summary>
        [Description("Distrito Federal")]
        DF,
        /// <summary>
        /// Espírito Santo.
        /// </summary>
        [Description("Espírito Santo")]
        ES,
        /// <summary>
        /// Goiás.
        /// </summary>
        [Description("Goiás")]
        GO,
        /// <summary>
        /// Maranhão.
        /// </summary>
        [Description("Maranhão")]
        MA,
        /// <summary>
        /// Mato Grosso.
        /// </summary>
        [Description("Mato Grosso")]
        MT,
        /// <summary>
        /// Mato Grosso do Sul.
        /// </summary>
        [Description("Mato Grosso do Sul")]
        MS,
        /// <summary>
        /// Minas Gerais.
        /// </summary>
        [Description("Minas Gerais")]
        MG,
        /// <summary>
        /// Pará.
        /// </summary>
        [Description("Pará")]
        PA,
        /// <summary>
        /// Paraíba.
        /// </summary>
        [Description("Paraíba")]
        PB,
        /// <summary>
        /// Paraná.
        /// </summary>
        [Description("Paraná")]
        PR,
        /// <summary>
        /// Pernambuco.
        /// </summary>
        [Description("Pernambuco")]
        PE,
        /// <summary>
        /// Piauí.
        /// </summary>
        [Description("Piauí")]
        PI,
        /// <summary>
        /// Rio de Janeiro.
        /// </summary>
        [Description("Rio de Janeiro")]
        RJ,
        /// <summary>
        /// Rio Grande do Norte.
        /// </summary>
        [Description("Rio Grande do Norte")]
        RN,
        /// <summary>
        /// Rio Grande do Sul.
        /// </summary>
        [Description("Rio Grande do Sul")]
        RS,
        /// <summary>
        /// Rondônia.
        /// </summary>
        [Description("Rondônia")]
        RO,
        /// <summary>
        /// Roraima.
        /// </summary>
        [Description("Roraima")]
        RR,
        /// <summary>
        /// Santa Catarina.
        /// </summary>
        [Description("Acre")]
        SC,
        /// <summary>
        /// São Paulo.
        /// </summary>
        [Description("São Paulo")]
        SP,
        /// <summary>
        /// Sergipe.
        /// </summary>
        [Description("Sergipe")]
        SE,
        /// <summary>
        /// Tocantins.
        /// </summary>
        [Description("Tocantins")]
        TO
    }


    
    
}
