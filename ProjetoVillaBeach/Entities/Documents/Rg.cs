using ProjetoVillaBeach.Entities.Base;
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
        public string Number
        {
            get
            {
                return _number;
            }
            set
            {
                SetProperty(ref _number, value);
            }
        }
        private string _number;

        public EnumIssuingAgency? IssuingAgency
        {
            get
            {
                return _issuingAgency;
            }
            set
            {
                SetProperty(ref _issuingAgency, value);
            }
        }
        private EnumIssuingAgency? _issuingAgency;

        public EnumStates? IssuingState
        {
            get
            {
                return _issuingState;
            }
            set
            {
                SetProperty(ref _issuingState, value);
            }
        }
        private EnumStates? _issuingState;

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
