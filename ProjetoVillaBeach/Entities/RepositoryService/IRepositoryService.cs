using System.Collections.Generic;

namespace ProjetoVillaBeach.Entities.RepositoryService
{
    public interface IRepositoryService<T>
    {
        bool Salvar(T objeto);

        bool Excluir(T objeto);

        T? Pesquisar(int codigo);

        ICollection<T> PesquisarTodos();

        ICollection<T> PesquisarTexto(string descricao);
    }
}
