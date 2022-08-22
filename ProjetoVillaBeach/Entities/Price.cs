using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using ProjetoVillaBeach.Entities.Base;

namespace ProjetoVillaBeach.Entities
{
    public class Price : DateBaseClass
    {
        public decimal Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Valor não pode ser menor que Zero");
                SetProperty(ref _value, value);
            }
        }
        private decimal _value;
    }
}
