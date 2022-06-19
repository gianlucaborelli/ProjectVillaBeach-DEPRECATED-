using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoVillaBeach.Classes
{
    public class Email : IEntityObjectState
    {
        [Key]
        public int IdEmail { get; set; }
        public string Endereco { get; set; }
        public string Observacao { get; set; }

        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }

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

        public Email()
        {
            if (new EmailAddressAttribute().IsValid((Endereco)))
            { 

            }
        }
    }
}
