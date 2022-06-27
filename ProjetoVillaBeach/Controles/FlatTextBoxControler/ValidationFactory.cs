using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Controles.FlatTextBoxControler
{
    internal static class ValidationFactory
    {
        public static IValidationServices GetValidator(EnumValidationType type)
        {
            IValidationServices validator = null;

            switch (type)
            {
                case EnumValidationType.CPF:
                    validator = new CpfValidationServices();
                    break;
                case EnumValidationType.CNPJ:
                    validator = new CnpjValidationServices();
                    break;
                case EnumValidationType.Date:
                    validator = new DateValidationServices();
                    break;
                case EnumValidationType.PIS:
                    validator = new PisValidationServices();
                    break;
                case EnumValidationType.EMail:
                    validator = new EmailValidationServices();
                    break;
                default:
                    validator = new UndefinedtextValidationServices();
                    break;
            }

            return validator;
        }
    }
}
