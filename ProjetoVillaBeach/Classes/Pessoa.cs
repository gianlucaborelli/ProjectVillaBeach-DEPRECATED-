using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ProjetoVillaBeach.Controles;
using System.Windows.Forms;

namespace ProjetoVillaBeach.Classes
{
    public class Pessoa : IEntityObjectState
    {
        [Key]
        public int IdPessoa { get; set; }

        [Required]
        public ulong? NumeroCpf { get; private set; }

        public ulong? NumeroRg { get; private set; }

        [Required]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 255 caracteres")]
        public string? Nome { get; private set; }

        [StringLength(255, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 255 caracteres")]
        public string? Filiacao1 { get; private set; }

        [StringLength(255, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 255 caracteres")]
        public string? Filiacao2 { get; private set; }

        public DateTime? DataDeNascimento { get; private set; }

        public DateTime DataDeCadastro { get; private set; }

        public virtual List<Telefone> Telefones { get; set; }

        public virtual List<Email> Email { get; set; }

        private List<Endereco> _enderecos = new List<Endereco>();
        public virtual List<Endereco> Enderecos
        {
            get
            {
                return _enderecos;
            }
            set
            {
                _enderecos = value;
            }
        }

        public virtual List<Matricula> Matriculas { get; set; }

        [NotMapped]
        public EntityObjectState ObjectState
        {
            get
            {
                return _objectState;
            }
            set
            {
                _objectState = value;
            }
        }
        private EntityObjectState _objectState = EntityObjectState.Unchanged;

        public Pessoa()
        {

        }

        public bool Salvar()
        {
            bool status = false;

            try
            {
                using (var contexto = new Contexto())
                {
                    switch (this.ObjectState)
                    {
                        case EntityObjectState.Added:
                            contexto.Pessoas.Attach(this).State = EntityState.Added;
                            break;
                        case EntityObjectState.Modified:
                            contexto.Pessoas.Attach(this).State = EntityState.Modified;
                            break;
                        case EntityObjectState.Deleted:
                            contexto.Pessoas.Attach(this).State = EntityState.Deleted;
                            break;
                        default:
                            contexto.Pessoas.Attach(this).State = EntityState.Unchanged;
                            break;
                    }

                    foreach (Endereco endereco in this.Enderecos)
                    {
                        switch (endereco.ObjectState)
                        {
                            case EntityObjectState.Added:
                                contexto.Entry(endereco).State = EntityState.Added;
                                break;
                            case EntityObjectState.Modified:
                                contexto.Entry(endereco).State = EntityState.Modified;
                                break;
                            case EntityObjectState.Deleted:
                                contexto.Entry(endereco).State = EntityState.Deleted;
                                break;
                            default:
                                contexto.Entry(endereco).State = EntityState.Unchanged;
                                break;
                        }
                    }

                    contexto.SaveChanges();
                    NotificacaoPopUp.MostrarNotificacao("Salvo com sucesso", NotificacaoPopUp.AlertType.Success);
                    status = true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Duplicate"))
                    MessageBox.Show(ex.ToString());
                else
                    MessageBox.Show(ex.ToString());
            }
            finally
            {

            }
            return status;
        }

        public static ICollection<Pessoa> SelecionaTodos()
        {
            var contexto = new Contexto();
            return contexto.Pessoas.ToList();
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
                contexto.Set<Pessoa>().Update(this);

                contexto.SaveChanges();
            }
        }

        public static List<Pessoa> Pesquisar(string? nome, ulong? cpf)
        {
            using (var contexto = new Contexto())
            {
                IQueryable<Pessoa> query = contexto.Pessoas;
                if (nome != null) query = query.Where(x => x.Nome == nome);
                if (cpf != null) query = query.Where(x => x.NumeroCpf == cpf);
                
                return query.ToList();
            }
        }

        public bool InformaCpf(ulong? cpf)
        {
            
            return false;
        }
        public bool InformaRg(ulong rg)
        {
            if (this.NumeroRg != rg)
            {
                this.NumeroRg = rg;

                if (ObjectState != EntityObjectState.Added)
                    ObjectState = EntityObjectState.Modified;

                return true;
            }

            return false;
        }
        public bool InformaNome(string nome)
        {
            if (this.Nome != nome)
            {
                this.Nome = nome;

                if (ObjectState != EntityObjectState.Added)
                    ObjectState = EntityObjectState.Modified;

                return true;
            }

            return false;
        }
        public bool InformaFiciliacao1(string filiacao1)
        {
            if (this.Filiacao1 != filiacao1)
            {
                this.Filiacao1 = filiacao1;

                if (ObjectState != EntityObjectState.Added)
                    ObjectState = EntityObjectState.Modified;

                return true;
            }

            return false;
        }
        public bool InformaFiciliacao2(string filiacao2)
        {
            if (this.Filiacao2 != filiacao2)
            {
                this.Filiacao2 = filiacao2;

                if (ObjectState != EntityObjectState.Added)
                    ObjectState = EntityObjectState.Modified;

                return true;
            }

            return false;
        }
        public bool InformaDataDeNascimento(DateTime? dataDeNascimento)
        {
            if (dataDeNascimento != DataDeNascimento && dataDeNascimento != null)
            {
                if (dataDeNascimento < DateTime.Now)
                {
                    this.DataDeNascimento = dataDeNascimento;

                    if (ObjectState != EntityObjectState.Added)
                        ObjectState = EntityObjectState.Modified;

                    return true;
                }
                else
                {
                    NotificacaoPopUp.MostrarNotificacao("A data de Nascimento tem que ser menor que a data Atual",
                                                        NotificacaoPopUp.AlertType.Warning);
                }
            }
            else
            {
                NotificacaoPopUp.MostrarNotificacao("Data Inválida",
                                                    NotificacaoPopUp.AlertType.Warning);
            }

            return false;
        }
        public bool InformaDataDeCadastro(DateTime? dataDeCadastro)
        {
            if (dataDeCadastro != DataDeNascimento && dataDeCadastro != null)
            {
                if (dataDeCadastro <= DateTime.Now)
                {
                    this.DataDeNascimento = dataDeCadastro;

                    if (ObjectState != EntityObjectState.Added)
                        ObjectState = EntityObjectState.Modified;

                    return true;
                }
                else
                {
                    NotificacaoPopUp.MostrarNotificacao("A data de Cadastro tem que ser menor ou igual a data Atual",
                                                        NotificacaoPopUp.AlertType.Warning);
                }
            }
            else
            {
                NotificacaoPopUp.MostrarNotificacao("Data Inválida",
                                                    NotificacaoPopUp.AlertType.Warning);
            }

            return false;
        }
    }
}
