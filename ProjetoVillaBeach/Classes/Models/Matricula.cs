using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Classes
{
    public class Matricula : BaseClass
    {
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

        public DateTime DataFim
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
        private DateTime _dataFim;

        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        public int IdModalidade { get; set; }
        public virtual Course Modalidade { get; set; }

        public virtual List<Mensalidade> Mensalidades { get; set; }
    }
}
