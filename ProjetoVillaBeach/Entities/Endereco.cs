using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Net.Http.Headers;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using ProjetoVillaBeach.Entities.Base;

namespace ProjetoVillaBeach.Entities
{
    public class Endereco : BaseClass
    {
        public string? Cep
        {
            get
            {
                return _cep;
            }
            set
            {
                SetProperty(ref _cep, value);
            }
        }
        private string? _cep;

        public string? Logradouro 
        {
            get
            { 
                return _logradouro;
            } 
            set
            {
                SetProperty(ref _logradouro, value);
            }
        }
        private string? _logradouro;

        public string? Numero 
        { 
            get 
            {
                return _numero;
            }
            set
            {
                SetProperty(ref _numero, value);
            }
        }
        private string? _numero;

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Bairro deve conter de 3 a 100 caracteres")]
        public string? Bairro 
        {
            get 
            {
                return _bairro;
            }
            set
            {
                SetProperty(ref _bairro, value);
            }
        }
        private string? _bairro;

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Cidade deve conter de 3 a 100 caracteres")]
        public string? Localidade
        {
            get
            {
                return _localidade;
            }
            set
            {
                SetProperty(ref _localidade, value);
            }
        }
        private string? _localidade;

        [StringLength(2, MinimumLength = 2, ErrorMessage = "Estado deve conter 2 caracteres")]
        public string? Uf
        {
            get
            {
                return _uf;
            }
            set
            {
                SetProperty(ref _uf, value);
            }
        }
        private string? _uf;

        [StringLength(100, ErrorMessage = "OBservação deve conter o maximo de 100 caracteres")]
        public string? Obs
        {
            get
            {
                return _obs;
            }
            set
            {
                SetProperty(ref _obs, value);
            }
        }
        private string? _obs;

        public int IdPessoa { get; set; }
        public virtual People Pessoa { get; set; }

        public Endereco()
        {

        }

        public Endereco(string cep)
        {
            Endereco endereco = ConstroiAsync(cep);

            Logradouro = endereco.Logradouro;
            Bairro = endereco.Bairro;
            Localidade = endereco.Localidade;
            Uf = endereco.Uf;
            Cep = endereco.Cep;
        }

        public static string TrataCep(string cep)
        {
            if (cep != null)
            {
                if (cep.Length >= 8)
                {
                    cep = cep.Trim();
                    cep = cep.Replace("-", "");
                    cep = cep.Insert(5, "-");
                }
            }

            return cep;
        }

        public static async Task<Endereco> RunAsync(string cep)
        {
            using (HttpClient? client = new())
            {
                Endereco endereco = new();

                var response = client.GetAsync("https://viacep.com.br/ws/" + cep + "/json/").Result;

                if (response.IsSuccessStatusCode)
                {
                    endereco = await response.Content.ReadAsAsync<Endereco>();
                }
                return endereco;
            }
        }

        public static Endereco ConstroiAsync(string cep)
        {
            Endereco obj = RunAsync(cep).Result;
            return obj;
        }

        public void Salvar()
        {
            var contexto = new Contexto();
            contexto.Enderecos.Add(this);
            contexto.SaveChanges();
        }

        public static ICollection<Endereco> SelecionaTodos()
        {
            var contexto = new Contexto();
            return contexto.Enderecos.ToList();
        }

        public void Excluir()
        {
            var contexto = new Contexto();
            contexto.Remove(this);
            contexto.SaveChanges();
        }

        public void Atualizar()
        {
            using (Contexto? contexto = new())
            {
                contexto.Entry(this).State = EntityState.Modified;

                contexto.SaveChanges();
            }
        }
    }
}