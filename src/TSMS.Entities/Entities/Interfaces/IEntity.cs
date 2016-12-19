using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TSMS.Entities.Interfaces
{
    interface IEntity
    {
        //Guid Id { get; set; }
        bool IsActive { get; set; }

        DateTime Created { get; set; }
        DateTime Modified { get; set; }
    }
}
