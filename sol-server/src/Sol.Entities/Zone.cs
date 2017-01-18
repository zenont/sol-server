using Sol.Common;
using System.Collections.Generic;

namespace Sol.Entities
{
    public class Zone: Int32EntityBase
    {
        public int MarketId { get; set; }

        public virtual Market Market { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    }
}
