﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol.Common
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
