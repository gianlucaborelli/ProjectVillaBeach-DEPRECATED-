using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoVillaBeach.Entities;
using ProjetoVillaBeach.Entities.Base;
using ProjetoVillaBeach.Entities.RepositoryService;

namespace ProjetoVillaBeach.Entities.Controllers
{
    internal class PeopleController
    {
        private PeopleRepositoryService peopleService = new();

        public Person SelectedPeople { get; private set; }
     
        public PeopleController()
        {
            SelectedPeople = new();
            SelectedPeople.ObjectState = EntityObjectState.Added;
        }

        public PeopleController(Person people)
        {
            SelectedPeople = people;
        }

        public bool Salvar()
        {
            if (string.IsNullOrEmpty(SelectedPeople.Nome))
                throw new InvalidOperationException("Nome não pode estar em Branco");

            if (SelectedPeople.DataDeCadastro == null)
                SelectedPeople.DataDeCadastro = DateTime.Now;

            return peopleService.Salvar(this.SelectedPeople);
        }

        public bool Excluir()
        {
            return peopleService.Excluir(this.SelectedPeople);
        }

        public Person? Pesquisar(int codigo)
        {
            return peopleService.Pesquisar(codigo);
        }

        public ICollection<Person> PesquisarTodos()
        {
            return peopleService.PesquisarTodos();
        }

        public ICollection<Person> PesquisarTexto(string descricao)
        {
            return peopleService.PesquisarTexto(descricao);
        }

        

    }
}
