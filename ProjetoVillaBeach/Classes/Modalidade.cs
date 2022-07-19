using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Classes
{
    public class Modalidade : IEntityObjectState
    {
        [Key]
        public int IdModalidade { get; set; }
        [Required]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 150 caracteres")]
        public string? Nome { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 255 caracteres")]
        public string? Observacao { get; set; }

        [Required]        
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }

        public virtual List<ValoresModalidade> ValoresModalidades { get; set; }
        public virtual List<Matricula> Matriculas { get; set; }//Modalidade não tem Matricula

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

        public void Salvar()
        {
            this.DataInicial = DateTime.Now;
            var contexto = new Contexto();
            contexto.Modalidades.Add(this);
            contexto.SaveChanges();
        }

        public static ICollection<Modalidade> SelecionaTodos()
        {
            var contexto = new Contexto();
            return contexto.Modalidades.ToList();            
        }

        public void Excluir()
        {
            var contexto = new Contexto();
            contexto.Remove(this);
            contexto.SaveChanges();            
        }

        public void Atualizar()
        {
            using (var contexto = new Contexto())
            {
                contexto.Set<Modalidade>().Update(this);

                contexto.SaveChanges();
            }
        }
    }    
}
