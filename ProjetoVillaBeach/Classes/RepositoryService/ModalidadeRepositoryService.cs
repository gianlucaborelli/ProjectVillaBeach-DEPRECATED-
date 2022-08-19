using System.Collections.Generic;
using System.Linq;

namespace ProjetoVillaBeach.Classes.RepositoryService
{
    public class ModalidadeRepositoryService : IRepositoryService<Course>
    {
        public bool Excluir(Course objeto)
        {
            var contexto = new Contexto();
            contexto.Remove(objeto);
            return (contexto.SaveChanges() > 0);
        }

        public Course? Pesquisar(int codigo)
        {
            var contexto = new Contexto();
            return (from p in contexto.Courses where p.Id == codigo select p).FirstOrDefault();            
        }

        public ICollection<Course> PesquisarTexto(string descricao)
        {
            var contexto = new Contexto();
            return (from p in contexto.Courses
                    where p.Name.ToUpper().Contains(descricao.ToUpper())
                        select p).ToList();
        }

        public ICollection<Course> PesquisarTodos()
        {
            var contexto = new Contexto();
            return contexto.Courses.ToList();            
        }

        public bool Salvar(Course objeto)
        {
            var contexto = new Contexto();
            contexto.Courses.Add(objeto);
            return (contexto.SaveChanges() > 0);
        }
    }
}
