using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSMS.Entities.Interfaces;

namespace TSMS.Entities
{
    public abstract class EntityBase :IEntity
    {
        // public int Id { get; protected set; }

        public EntityBase()
        {
            Created = DateTime.Now;
            Modified = Created;
        }
        public bool IsActive { get; set; }

        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

    }
}
