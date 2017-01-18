using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Mvc.Ext.ActionResults
{
    public class WrappedStatusCodeResult:ObjectResult
    {
        public WrappedStatusCodeResult(HttpStatusCode statusCode, object value) : base(new WrappedResult { Data = value })
        {
            StatusCode = (int)statusCode;
        }
    }
}
