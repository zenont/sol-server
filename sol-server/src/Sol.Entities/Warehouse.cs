using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sol.Common;

namespace Sol.Entities
{
    public class Warehouse:GuidEntityBase
    {
        public Guid TenantId { get; set; }

        public string Name { get; set; }
    }
}
