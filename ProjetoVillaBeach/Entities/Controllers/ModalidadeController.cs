using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoVillaBeach.Classes.RepositoryService;
using ProjetoVillaBeach.Formularios.Cadastros;

namespace ProjetoVillaBeach.Classes.Controllers
{
    public class ModalidadeController
    {
        private CourseRepositoryService modalidade = new();

        public Course ModalidadeSelecionada { get; set; }

        public ModalidadeController()
        {
            ModalidadeSelecionada = new();
            ModalidadeSelecionada.ObjectState = EntityObjectState.Added;
        }

        public ModalidadeController(Course mod)
        {
            ModalidadeSelecionada = mod;
        }

        public bool Salvar()
        {            
            return modalidade.Salvar(this.ModalidadeSelecionada);
        }

        public bool Excluir()
        {
            return modalidade.Excluir(this.ModalidadeSelecionada);
        }

        public Course? Pesquisar(int codigo)
        {
            return modalidade.Pesquisar(codigo);
        }

        public ICollection<Course> PesquisarTodos()
        {
            return modalidade.PesquisarTodos();
        }

        public ICollection<Course> PesquisarTexto(string descricao)
        {
            return modalidade.PesquisarTexto(descricao);
        }

        public void AddValorModalidade(Price valorModalidade)
        {
            if(ModalidadeSelecionada.DataFim != null)
                throw new ArgumentException("A Modalidade não está mais ativa");

            if(valorModalidade.DataInicio < ModalidadeSelecionada.DataInicio)            
                throw new ArgumentException("A Data de inicio do valor não pode ser menor que o inicio da modalidade");
            
            foreach (Price valor in ModalidadeSelecionada.Prices)
            {
                if (valor.DataFim == null)
                {
                    valor.DataFim = valorModalidade.DataInicio;
                    valor.DataFim = valor.DataFim.Value.AddDays(-1);
                }
            }
            ModalidadeSelecionada.Prices.Add(valorModalidade);
        }
    }
}
