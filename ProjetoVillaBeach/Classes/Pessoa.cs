using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ProjetoVillaBeach.Controles;
using ProjetoVillaBeach.Classes.Documents;
using System.Windows.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProjetoVillaBeach.Classes
{
    public class Pessoa : IEntityObjectState, INotifyPropertyChanged
    {
        #region Property

        [Key]
        public int IdPessoa { get; set; }

        [Required]
        public ulong? NumeroCpf 
        { 
            get 
            { 
                return _numeroCpf; 
            } 
            set 
            {
                if (Cpf.IsCpf(value.ToString()) && Cpf.IsUnique(value.ToString()))
                {
                    _numeroCpf = value;
                    OnPropertyChanged();
                }
                else
                {
                    throw new ArgumentException("C.P.F. invalido ou ja cadastrado");
                }
            }
        }
        private ulong? _numeroCpf;

        public string? NumeroRg
        {
            get
            {
                return _numeroRg;
            }
            set
            {
                _numeroRg = value;
                OnPropertyChanged();
            }
        }
        private string? _numeroRg;

        [Required]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 255 caracteres")]
        public string? Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
                OnPropertyChanged();
            }
        }
        private string? _nome;

        [StringLength(255, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 255 caracteres")]
        public string? Filiacao1
        {
            get
            {
                return _filiacao1;
            }
            set
            {
                _filiacao1 = value;
                OnPropertyChanged();
            }
        }
        private string _filiacao1;

        [StringLength(255, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 255 caracteres")]
        public string? Filiacao2
        {
            get
            {
                return _filiacao2;
            }
            set
            {
                _filiacao2 = value;
                OnPropertyChanged();
            }
        }
        private string _filiacao2;

        public DateTime? DataDeNascimento
        {
            get
            {
                return _dataDeNascimento;
            }
            set
            {
                if (value <= DateTime.Now)
                {
                    _dataDeNascimento = value;
                    OnPropertyChanged();
                }
                else
                {
                    throw new ArgumentException("A data de Nascimento deve ser menor que a data Atual");
                }
                
            }
        }
        private DateTime? _dataDeNascimento;

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

        #endregion

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void PropertyChanged_Method(object sender, PropertyChangedEventArgs e)
        {
            if (ObjectState != EntityObjectState.Added)
                ObjectState = EntityObjectState.Modified;
        }
        #endregion

        public Pessoa()
        {
            this.PropertyChanged += PropertyChanged_Method;
        }

        public bool Salvar()
        {
            bool status = false;

            if (DataDeCadastro == DateTime.Parse("01/01/0001"))
                DataDeCadastro = DateTime.Now;

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

        public static List<Pessoa> Pesquisar(string? nome, ulong? cpf, string? rg)
        {
            using (var contexto = new Contexto())
            {
                IQueryable<Pessoa> query = contexto.Pessoas;
                query = query.Where(x => x.Nome == nome || x.NumeroCpf == cpf || x.NumeroRg == rg);

                return query.ToList();
            }
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

    }
}
