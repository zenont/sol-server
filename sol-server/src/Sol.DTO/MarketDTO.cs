using Sol.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol.DTO
{
    public class MarketDTO : Int32EntityBase
    {
        public string Name { get; set; }

        public string Code { get; set; }
    }
}
