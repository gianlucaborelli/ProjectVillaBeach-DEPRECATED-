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

namespace ProjetoVillaBeach.Classes
{
    public class Endereco : IEntityObjectState
    {
        [Key]
        public int IdEndereco { get; set; }      
        public string? Cep { get; set; }
        public string? Logradouro { get; set; }
        public string? Numero { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Bairro deve conter de 3 a 100 caracteres")]
        public string? Bairro { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Cidade deve conter de 3 a 100 caracteres")]
        public string? Localidade { get; set; }

        [StringLength(2, MinimumLength = 2, ErrorMessage = "Estado deve conter 2 caracteres")]
        public string? Uf { get; set; }

        [StringLength(100, ErrorMessage = "OBservação deve conter o maximo de 100 caracteres")]
        public string? Obs { get; set; }

        public int IdPessoa { get; set; }
        public virtual Pessoa Pessoa { get; set; }

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