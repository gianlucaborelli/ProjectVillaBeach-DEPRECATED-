using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Classes
{
    public abstract class BaseClass: NotifyBase, IEntityObjectState
    {
        [Key]
        public int Id { get; set; }

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

        protected bool SetProperty<T>(ref T _backField, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(_backField, value))
                return false;

            _backField = value;
            OnPropertyChanged(propertyName);

            if (ObjectState != EntityObjectState.Added)
                ObjectState = EntityObjectState.Modified;

            return true;
        }
    }
}
