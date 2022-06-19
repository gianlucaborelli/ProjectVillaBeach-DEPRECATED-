using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Classes
{
    public class Telefone : IEntityObjectState
    {
        [Key]
        public int IdTelefone { get; set; }        
        public int Numero { get; set; }
        public string Observacao { get; set; }

        public int IdPessoa { get; set; }
        public virtual Pessoa? Pessoa { get; set; }

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

        public Telefone()
        {

        }

    }
}
