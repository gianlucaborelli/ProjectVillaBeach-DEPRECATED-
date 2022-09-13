using ProjetoVillaBeach.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Entities.Documents
{
    public enum BookType
    {
        /// <summary>
        /// Book where births are recorded.
        /// </summary>
        A,
        /// <summary>
        /// Book where marriages are registered.
        /// </summary>
        B,
        /// <summary>
        /// Book where religious marriages are registered.
        /// </summary>
        BAuxiliar,
        /// <summary>
        /// Book where deaths are recorded.
        /// </summary>
        C,
        /// <summary>
        /// Book where stillbirths are recorded.
        /// </summary>
        CAuxiliar,
        /// <summary>
        /// Book where proclamations edicts are registered.
        /// </summary>
        D,
        /// <summary>
        /// Book where other civil acts are recorded, such as emancipation, interdiction and nationality.
        /// </summary>
        E
    }

    public class CivilRegistrationOld: Document
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

        public BookType Type
        {
            get
            {
                return _type;
            }
            set
            {
                SetProperty(ref _type, value);
            }
        }
        private BookType _type;

        public string Book
        {
            get
            {
                return _book;
            }
            set
            {
                SetProperty(ref _book, value);
            }
        }
        private string _book;

        public string? Sheet
        {
            get
            {
                return _sheet;
            }
            set
            {
                SetProperty(ref _sheet, value);
            }
        }
        private string? _sheet;

        public string? JudicialDistrict
        {
            get
            {
                return _judicialDistrict;
            }
            set
            {
                SetProperty(ref _judicialDistrict, value);
            }
        }
        private string? _judicialDistrict;

        public string? NotarysOffice
        {
            get
            {
                return _notarysOffice;
            }
            set
            {
                SetProperty(ref _notarysOffice, value);
            }
        }
        private string? _notarysOffice;

        public EnumStates State
        {
            get
            {
                return state;
            }
            set
            {
                SetProperty(ref state, value);
            }
        }
        private EnumStates state;
        
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
