using Microsoft.EntityFrameworkCore;

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
                if(value > DataInicial)
                {
                    SetaFimDeModalidade();
                    SetProperty(ref _dataFinal, value);                    
                }
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

        public Modalidade()
        {
            
        }

        private void SetaFimDeModalidade()
        {
            foreach(ValoresModalidade valor in ValoresModalidades)
            {
                if(valor.DataFim == null)
                {
                    valor.DataFim = this.DataFinal;
                }
            }
        }

        public void Salvar()
        {
            if (DataInicial == DateTime.Parse("01/01/0001"))
                DataInicial = DateTime.Now;

            try
            {
                using (var contexto = new Contexto())
                {
                    switch (this.ObjectState)
                    {
                        case EntityObjectState.Added:
                            contexto.Modalidades.Attach(this).State = EntityState.Added;
                            break;
                        case EntityObjectState.Modified:
                            contexto.Modalidades.Attach(this).State = EntityState.Modified;
                            break;
                        case EntityObjectState.Deleted:
                            contexto.Modalidades.Attach(this).State = EntityState.Deleted;
                            break;
                        default:
                            contexto.Modalidades.Attach(this).State = EntityState.Unchanged;
                            break;
                    }

                    foreach (ValoresModalidade valor in this.ValoresModalidades)
                    {
                        switch (valor.ObjectState)
                        {
                            case EntityObjectState.Added:
                                contexto.Entry(valor).State = EntityState.Added;
                                break;
                            case EntityObjectState.Modified:
                                contexto.Entry(valor).State = EntityState.Modified;
                                break;
                            case EntityObjectState.Deleted:
                                contexto.Entry(valor).State = EntityState.Deleted;
                                break;
                            default:
                                contexto.Entry(valor).State = EntityState.Unchanged;
                                break;
                        }
                    }

                    contexto.SaveChanges();
                    NotificacaoPopUp.MostrarNotificacao("Salvo com sucesso", NotificacaoPopUp.AlertType.Success);

                    this.ObjectState = EntityObjectState.Unchanged;

                    foreach (ValoresModalidade valor in this.ValoresModalidades)
                    {
                        if (valor.ObjectState != EntityObjectState.Unchanged)
                            valor.ObjectState = EntityObjectState.Unchanged;

                    }
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

        public void Atualizar()
        {
            using (var contexto = new Contexto())
            {
                contexto.Set<Modalidade>().Update(this);

                contexto.SaveChanges();
            }
        }
    }
}
