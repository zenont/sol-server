using Sol.Common;

namespace Sol.Entities
{
    public class Zone: Int32EntityBase
    {
        public int MarketId { get; set; }

        public virtual Market Market { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
    }
}
