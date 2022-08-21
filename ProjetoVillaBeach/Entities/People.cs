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
using System.Drawing;
using System.IO;
using System.Configuration;

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
                if (value >= DateTime.Now)
                    throw new ArgumentException("A data de Nascimento não pode ser maior que a data Atual");

                SetProperty(ref _dataDeNascimento, value);
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
        private List<Endereco> _enderecos = new List<Endereco>();

        public virtual List<Matricula> Matriculas { get; set; }

        public string? PathPhoto { get; set; }

        [NotMapped]
        public Image? Photo
        {
            get
            {
                if (PathPhoto == null)
                    return null;
                return Image.FromFile(PathPhoto);
            }
            set
            {
                if (value != null)
                    SetPhoto(value);
            }
        }

        [NotMapped]
        private string? TempPathPhoto;        

        #endregion
                
        private void SetPhoto(Image photo)
        {
            TempPathPhoto = "C:\\Nova pasta\\" + Id.ToString() + ".png";

            if (File.Exists(TempPathPhoto))
                File.Delete(TempPathPhoto);

            photo.Save(TempPathPhoto, System.Drawing.Imaging.ImageFormat.Png);
            //Photo.Dispose();
            //Photo = photo;
        }

        public void SavePhoto()
        {
            if (TempPathPhoto == null)
                return;

            var path = ConfigurationManager.AppSettings["PathPhoto"] + Id.ToString() + ".png";

            if (File.Exists(TempPathPhoto))
                File.Move(TempPathPhoto, path);

            File.Delete(TempPathPhoto);

            PathPhoto = path;
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
    }
}
