using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BaseClass<T> 
    {
        [Key]
        public int Id { get; set; }

        public virtual bool Salvar(bool Insert, T objeto) 
        {
            return false;
        }
        public virtual bool Excluir(T objeto)
        {
            return false;
        }
        public virtual T Pesquisar(int codigo)
        {
            return default(T);
        }
        public virtual List<T> PesquisarTodos()
        {
            return new List<T>();
        }
        public virtual List<T> PesquisarTexto(string descricao)
        {
            return new List<T>();
        }
    }
}
