using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Entities.Documents
{
    public class Rg : Document
    {
        public string RgNumber { get; set; }

        public string? IssuingAgency { get; set; }

        [StringLength(2)]
        public string? IssuingState { get; set; }

        public DateTime? IssueDate
        {
            get
            {
                return _issueDate;
            }
            set
            {
                SetProperty(ref _issueDate, value);
            }
        }
        private DateTime? _issueDate;


    }
}
