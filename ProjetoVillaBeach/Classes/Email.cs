using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoVillaBeach.Classes
{
    public class Email : BaseClass
    {
        public string EmailAddress 
        {
            get
            {
                return _emailAddress;
            }
            set
            {
                SetProperty(ref _emailAddress, value);
            }
        }
        private string _emailAddress;

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
        public virtual Pessoa Pessoa { get; set; }
             
        public Email()
        {
            if (new EmailAddressAttribute().IsValid((EmailAddress)))
            { 

            }
        }
    }
}
