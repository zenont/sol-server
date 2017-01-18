﻿using Sol.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol.DTO
{
    public class ZoneDTO : Int32EntityBase
    {
        public int MarketId { get; set; }

        public virtual MarketDTO Market { get; set; }

        public string Name { get; set; }

        public string Code { get; set; }
    }
}