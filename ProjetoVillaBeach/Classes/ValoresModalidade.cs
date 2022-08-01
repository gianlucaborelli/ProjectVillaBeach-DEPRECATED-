using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Classes
{
    public class ValoresModalidade : IEntityObjectState, INotifyPropertyChanged
    {
        [Key]
        public int IdValoresModalidades { get; set; }

        private double _valor;
        public double Valor
        {
            get
            {
                return _valor;
            }
            set
            {
                if (_valor != value)
                {
                    _valor = value;
                    OnPropertyChanged();
                }
            }
        }

        private DateTime _dataInicio;
        public DateTime DataInicio
        {
            get
            {
                return _dataInicio;
            }
            set
            {
                if (value != _dataInicio)
                {
                    _dataInicio = value;
                    OnPropertyChanged();
                }                    
            }
        }

        private DateTime? _dataFim;
        public DateTime? DataFim
        {
            get
            {
                return _dataFim;
            }
            set
            {
                if (value != _dataInicio)
                {
                    _dataFim = value;
                    OnPropertyChanged();
                }
            }
        }

        public int IdModalidade { get; set; }
        public virtual Modalidade Modalidade { get; set; }

        public virtual List<Mensalidade> Mensalidades { get; set; }

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

        #region INotifyPropertyChanged Implementation

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (ObjectState != EntityObjectState.Added)
                ObjectState = EntityObjectState.Modified;
        }
        #endregion
    }
}
