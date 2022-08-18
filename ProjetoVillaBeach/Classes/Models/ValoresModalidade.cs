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

namespace ProjetoVillaBeach.Classes
{
    public class ValoresModalidade : DateBaseClass
    {
        public decimal Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Valor não pode ser menor que Zero");
                SetProperty(ref _valor, value);
            }
        }
        private decimal _valor;
                
        public int IdModalidade { get; set; }
        public virtual Modalidade Modalidade { get; set; }

        public virtual List<Mensalidade> Mensalidades { get; set; }
    }
}
