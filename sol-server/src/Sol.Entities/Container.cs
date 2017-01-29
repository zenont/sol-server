using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sol.Common;

namespace Sol.Entities
{
    public class Container:GuidEntityBase
    {
        public Guid WarehouseId { get; set; }

        public string Name { get; set; }
    }
}
