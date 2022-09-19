using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Entities.RepositoryService
{
    internal class PeopleRepositoryService : IRepositoryService<Person>
    {
        public bool Excluir(Person objeto)
        {
            var contexto = new Contexto();
            contexto.Remove(objeto);
            return (contexto.SaveChanges() > 0);
        }

        public Person? Pesquisar(int codigo)
        {
            var contexto = new Contexto();
            return (from p in contexto.Peoples where p.Id == codigo select p).FirstOrDefault();
        }

        public ICollection<Person> PesquisarTexto(string descricao)
        {
            var contexto = new Contexto();
            return (from p in contexto.Peoples
                    where p.Nome.ToUpper().Contains(descricao.ToUpper())
                    select p).ToList();
        }

        public ICollection<Person> PesquisarTodos()
        {
            var contexto = new Contexto();
            return contexto.Peoples.ToList();
        }

        public bool Salvar(Person objeto)
        {
            var contexto = new Contexto();
            contexto.Peoples.Add(objeto);
            objeto.SavePhoto();
            return (contexto.SaveChanges() > 0);
        }
    }
}
