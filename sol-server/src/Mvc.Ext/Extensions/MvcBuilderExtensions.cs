using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Ext.Extensions
{
    public static class MvcBuilderExtensions
    {
        public static IMvcBuilder WithCamelCaseJson(this IMvcBuilder builder)
        {
            return builder.AddJsonOptions(x => 
            {
                x.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            });
        }
    }
}
