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
    public class ValoresModalidade : BaseClass
    {
        public double Valor
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
        private double _valor;

        public DateTime DataInicio
        {
            get
            {
                return _dataInicio;
            }
            set
            {
                if (DataFim != null && value < DataFim)
                    throw new ArgumentException("A Data de inicio não pode ser maior que sua data final");

                SetProperty(ref _dataInicio, value);
            }
        }
        private DateTime _dataInicio;

        public DateTime? DataFim
        {
            get
            {
                return _dataFim;
            }
            set
            {
                if(value != null)
                {
                    if (value > DataInicio)
                        SetProperty(ref _dataFim, value);
                    else
                        throw new ArgumentException("A Data de inicio não pode ser maior que sua data final");
                }                
            }
        }
        private DateTime? _dataFim;

        public int IdModalidade { get; set; }
        public virtual Modalidade Modalidade { get; set; }

        public virtual List<Mensalidade> Mensalidades { get; set; }
    }
}
