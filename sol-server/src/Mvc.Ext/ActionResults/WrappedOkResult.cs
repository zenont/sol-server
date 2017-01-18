using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Ext.ActionResults
{
    public class WrappedOkResult : OkObjectResult
    {
        public WrappedOkResult(object value) : base(new WrappedResult { Data = value })
        {

        }
    }
}
