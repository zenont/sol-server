using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Ext.ActionResults
{
    public class WrappedObjectResult: ObjectResult
    {
        public WrappedObjectResult(object value) : base(new WrappedResult { Data = value })
        {

        }
    }
}
