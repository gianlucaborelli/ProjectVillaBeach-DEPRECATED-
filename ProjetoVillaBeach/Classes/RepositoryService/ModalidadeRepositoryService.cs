using System.Collections.Generic;
using System.Linq;

namespace ProjetoVillaBeach.Classes.RepositoryService
{
    public class ModalidadeRepositoryService : IRepositoryService<Modalidade>
    {
        public bool Excluir(Modalidade objeto)
        {
            var contexto = new Contexto();
            contexto.Remove(objeto);
            return (contexto.SaveChanges() > 0);
        }

        public Modalidade? Pesquisar(int codigo)
        {
            var contexto = new Contexto();
            return (from p in contexto.Modalidades where p.Id == codigo select p).FirstOrDefault();            
        }

        public ICollection<Modalidade> PesquisarTexto(string descricao)
        {
            var contexto = new Contexto();
            return (from p in contexto.Modalidades
                        where p.Nome.ToUpper().Contains(descricao.ToUpper())
                        select p).ToList();
        }

        public ICollection<Modalidade> PesquisarTodos()
        {
            var contexto = new Contexto();
            return contexto.Modalidades.ToList();            
        }

        public bool Salvar(Modalidade objeto)
        {
            var contexto = new Contexto();
            contexto.Modalidades.Add(objeto);
            return (contexto.SaveChanges() > 0);
        }
    }
}
