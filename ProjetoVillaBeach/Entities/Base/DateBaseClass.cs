using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoVillaBeach.Classes
{
    public abstract class DateBaseClass: BaseClass
    {
        public DateTime DataInicio
        {
            get
            {
                return _dataInicio;
            }
            set
            {
                if (DataFim != null && value < DataFim)
                    throw new ArgumentException("A Data de inicio não pode ser maior que sua data final");

                SetProperty(ref _dataInicio, value);
            }
        }
        private DateTime _dataInicio;

        public DateTime? DataFim
        {
            get
            {
                return _dataFim;
            }
            set
            {
                if (value != null)
                {
                    if (value > DataInicio)
                        SetProperty(ref _dataFim, value);
                    else
                        throw new ArgumentException("A Data de inicio não pode ser maior que sua data final");
                }
            }
        }
        private DateTime? _dataFim;

    }
}
