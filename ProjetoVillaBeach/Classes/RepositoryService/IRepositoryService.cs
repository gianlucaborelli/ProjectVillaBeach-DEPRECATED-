using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Classes.RepositoryService
{
    public interface IRepositoryService<T>
    {
        bool Salvar(bool Insert, T objeto);

        bool Excluir(T objeto);

        T Pesquisar(int codigo);

        ICollection<T> PesquisarTodos();

        ICollection<T> PesquisarTexto(string descricao);
    }
}
