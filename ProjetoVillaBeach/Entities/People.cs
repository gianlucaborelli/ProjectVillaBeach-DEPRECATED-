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
using ProjetoVillaBeach.Entities.Base;

namespace ProjetoVillaBeach.Entities
{
    public class People : BaseClass
    {
        #region Property

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
                    SetProperty(ref _numeroCpf, value);
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
                SetProperty(ref _numeroRg, value);
            }
        }
        private string? _numeroRg;

        [Required]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 255 caracteres")]
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
        public string? Filiacao1
        {
            get
            {
                return _filiacao1;
            }
            set
            {
                SetProperty(ref _filiacao1, value);
            }
        }
        private string? _filiacao1;

        [StringLength(255, MinimumLength = 3, ErrorMessage = "As informações diversas deve ter de 3 a 255 caracteres")]
        public string? Filiacao2
        {
            get
            {
                return _filiacao2;
            }
            set
            {
                SetProperty(ref _filiacao2, value);
            }
        }
        private string? _filiacao2;

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
                    SetProperty(ref _dataDeNascimento, value);
                }
                else
                {
                    throw new ArgumentException("A data de Nascimento deve ser menor que a data Atual");
                }

            }
        }
        private DateTime? _dataDeNascimento;

        public DateTime? DataDeCadastro
        {
            get
            {
                return _dataDeCadastro;
            }
            set
            {
                SetProperty(ref _dataDeCadastro, value);
            }
        }
        private DateTime? _dataDeCadastro;

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

        #endregion
        
        public bool Salvar()
        {
            bool status = false;

            if (DataDeCadastro == DateTime.Parse("01/01/0001"))
                DataDeCadastro = DateTime.Now;

            try
            {
                using (var contexto = new Contexto())
                {
                    contexto.SaveChanges();
                    NotificacaoPopUp.MostrarNotificacao("Salvo com sucesso", NotificacaoPopUp.AlertType.Success);
                    status = true;

                    this.ObjectState = EntityObjectState.Unchanged;
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

        public static ICollection<People> SelecionaTodos()
        {
            var contexto = new Contexto();
            return contexto.Peoples.ToList();
        }

        public static ICollection<People> Pesquisar(string? nome, ulong? cpf, string? rg, out string msg)
        {
            msg = "";
            var contexto = new Contexto();

            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(rg) && cpf != null)
            {
                IQueryable<People> query = contexto.Peoples;
                query = query.Where(x => x.Nome == nome || x.NumeroCpf == cpf || x.NumeroRg == rg);

                if (query.ToList().Count >= 1)
                    return query.ToList();
            }

            if (!string.IsNullOrEmpty(nome))
                msg = "Não foram encontradas pessoas com o parâmetro informado";

            return contexto.Peoples.ToList();
        }

        public void Excluir()
        {
            var contexto = new Contexto();
            contexto.Remove(this);
            contexto.SaveChanges();
        }
    }
}
