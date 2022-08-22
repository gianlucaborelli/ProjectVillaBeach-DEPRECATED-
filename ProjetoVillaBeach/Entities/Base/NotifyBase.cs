using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace ProjetoVillaBeach.Entities.Base
{
    public abstract class NotifyBase : INotifyPropertyChanged, IEntityObjectState
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

            if (ObjectState != EntityObjectState.Added)
                ObjectState = EntityObjectState.Modified;
        }

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

        protected bool SetProperty<T>(ref T _backField, T value, [CallerMemberName] string? propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(_backField, value))
                return false;

            _backField = value;
            OnPropertyChanged(propertyName);

            

            return true;
        }
    }
}
