using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoVillaBeach.Entities.Base
{
    public enum EntityObjectState
    {
        Added,
        Modified,
        Deleted,
        Unchanged
    }
    interface IEntityObjectState
    {
        EntityObjectState ObjectState { get; set; }
    }
}
