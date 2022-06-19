using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Classes
{
    public class Mensalidade : IEntityObjectState
    {
        [Key]
        public int IdMensalidade { get; set; }        
        public DateTime DataGerada { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataPagamento { get; set; }


        public int IdMatricula { get; set; }
        public virtual Matricula Matricula { get; set; }

        public int IdValorModalidade { get; set; }
        public virtual ValoresModalidade ValoresModalidade { get; set; }

        [NotMapped]
        public EntityObjectState ObjectState
        {
            get
            {
                return _objectState;
            }
            set
            {
                _objectState = value;
            }
        }
        private EntityObjectState _objectState = EntityObjectState.Unchanged;

    }
}
