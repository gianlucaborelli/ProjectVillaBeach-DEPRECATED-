using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ProjetoVillaBeach.Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Classes
{
    public class Modalidade : BaseClass
    {
        [Required]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 150 caracteres")]
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                SetProperty(ref _nome, value);
            }
        }
        private string _nome;

        [StringLength(255, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 255 caracteres")]
        public string? Observacao
        {
            get
            {
                return _observacao;
            }
            set
            {
                SetProperty(ref _observacao, value);
            }
        }
        private string? _observacao;

        [Required]
        public DateTime DataInicial
        {
            get
            {
                return _dataInicial;
            }
            set
            {                
                if (DataFinal != null && value < DataFinal)
                    throw new ArgumentException("A Data de inicio não pode ser maior que sua data final");
                else
                    SetProperty(ref _dataInicial, value);               
            }
        }
        private DateTime _dataInicial;

        public DateTime? DataFinal
        {
            get
            {
                return _dataFinal;
            }
            set
            {
                if (value > DataInicial)
                    SetProperty(ref _dataFinal, value);
                else
                    throw new ArgumentException("A Data de inicio não pode ser maior que sua data final");
            }
        }
        private DateTime? _dataFinal;

        public virtual List<ValoresModalidade> ValoresModalidades
        {
            get
            {
                return _valoresModalidades;
            }
            set
            {
                SetProperty(ref _valoresModalidades, value);
            }
        }
        private List<ValoresModalidade> _valoresModalidades = new();

        public virtual List<Matricula> Matriculas { get; set; }//Modalidade não tem Matricula

        public void Salvar()
        {
            if (DataInicial == DateTime.Parse("01/01/0001"))
                DataInicial = DateTime.Now;

            try
            {
                using (var contexto = new Contexto())
                {
                    contexto.Modalidades.Add(this);
                    contexto.SaveChanges();
                    NotificacaoPopUp.MostrarNotificacao("Salvo com sucesso", NotificacaoPopUp.AlertType.Success);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        public static ICollection<Modalidade> SelecionaTodos()
        {
            var contexto = new Contexto();
            return contexto.Modalidades.ToList();
        }

        public static ICollection<Modalidade> Pesquisar(string? nome, out string msg)
        {
            var contexto = new Contexto();
            msg = "";
            IQueryable<Modalidade> query = contexto.Modalidades;
            query = query.Where(x => x.Nome == nome);

            if (query.ToList().Count >= 1)
                return query.ToList();

            if (!string.IsNullOrEmpty(nome))
                msg = "Não foram encontradas modalidades com o parâmetro informado";

            return contexto.Modalidades.ToList();

        }

        public void Excluir()
        {
            var contexto = new Contexto();
            contexto.Remove(this);
            contexto.SaveChanges();
        }
    }
}
