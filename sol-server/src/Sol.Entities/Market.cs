using Sol.Common;
using System.Collections.Generic;

namespace Sol.Entities
{
    public class Market:Int32EntityBase
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public virtual ICollection<Zone> Zones { get; set; } = new List<Zone>();
    }
}
