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
        private ModalidadeRepositoryService modalidade = new();

        public Modalidade ModalidadeSelecionada { get; set; }

        public ModalidadeController()
        {
            ModalidadeSelecionada = new();
            ModalidadeSelecionada.ObjectState = EntityObjectState.Added;
        }

        public ModalidadeController(Modalidade mod)
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

        public Modalidade? Pesquisar(int codigo)
        {
            return modalidade.Pesquisar(codigo);
        }

        public ICollection<Modalidade> PesquisarTodos()
        {
            return modalidade.PesquisarTodos();
        }

        public ICollection<Modalidade> PesquisarTexto(string descricao)
        {
            return modalidade.PesquisarTexto(descricao);
        }

        public void AddValorModalidade(ValoresModalidade valorModalidade)
        {
            if(ModalidadeSelecionada.DataFinal != null)
                throw new ArgumentException("A Modalidade não está mais ativa");

            if(valorModalidade.DataInicio < ModalidadeSelecionada.DataInicial)            
                throw new ArgumentException("A Data de inicio do valor não pode ser menor que o inicio da modalidade");
            
            foreach (ValoresModalidade valor in ModalidadeSelecionada.ValoresModalidades)
            {
                if (valor.DataFim == null)
                {
                    valor.DataFim = valorModalidade.DataInicio;
                    valor.DataFim = valor.DataFim.Value.AddDays(-1);
                }
            }
            ModalidadeSelecionada.ValoresModalidades.Add(valorModalidade);
        }
    }
}
