using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Classes
{
    public class Telefone : BaseClass
    {
        public int Numero
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
        private int _numero;

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
        public virtual Pessoa? Pessoa { get; set; }
    }
}
