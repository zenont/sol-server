using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Mvc.Ext.ActionResults;

namespace Mvc.Ext
{
    public abstract class ApiControllerBase: ControllerBase
    {
        public virtual ObjectResult Wrapped(object value)
        {
            return new WrappedObjectResult(value);
        }

        public virtual OkObjectResult OkWrapped(object value)
        {
            return new WrappedOkResult(value);
        }

        public virtual BadRequestObjectResult BadRequestWrapped(object value)
        {
            return new WrappedBadRequestObjectResult(value);
        }

        public virtual ObjectResult StatusCodeWrapped(HttpStatusCode statusCode, object value)
        {
            return new WrappedStatusCodeResult(statusCode, value);
        }
    }
}
