using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Entities.Base
{
    //[Index(nameof(Number), IsUnique = true)]
    public abstract class DocumentBaseClass: NotifyBase
    {
        [Key]
        public int Id { get; set; }
                
        //public T Number { get; set; }

        public static bool IsUnique(string document)
        {
            using (var ctx = new Contexto())
            {
                var pessoa = ctx.Peoples
                                .Where(p => p.NumeroCpf == ulong.Parse(document))
                                .ToList();

                if (pessoa.Count == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
