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
                SetProperty(ref _dataFim, value);
            }
        }
        private DateTime? _dataFim;

        public int IdModalidade { get; set; }
        public virtual Modalidade Modalidade { get; set; }

        public virtual List<Mensalidade> Mensalidades { get; set; }
    }
}
