using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Classes
{
    public class ValoresModalidade : IEntityObjectState
    {
        [Key]
        public int IdValoresModalidades { get; set; }
        public double Valor { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime? DataFim { get; private set; }

        public int IdModalidade { get; set; }
        public virtual Modalidade Modalidade { get; set; }

        public virtual List<Mensalidade> Mensalidades { get; set; }

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
