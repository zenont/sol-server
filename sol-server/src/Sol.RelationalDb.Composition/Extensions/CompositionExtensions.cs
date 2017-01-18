using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Sol.RelationalDb.Composition.Extensions
{
    public static class CompositionExtensions
    {
        public static IServiceCollection AddSolDb(this IServiceCollection services,
            IConfiguration configuration,
            ServiceLifetime serviceLifetime = ServiceLifetime.Scoped,
            string configSection = "ConnectionStrings",
            string configConnectionStringKey = "SolDb")
        {
            services.AddDbContext<SolDb>(options => options.UseSqlServer(configuration[$"{configSection}:{configConnectionStringKey}"],
                b =>
                {
                    b.UseRowNumberForPaging();
                    /* b.EnableRetryOnFailure(); */
                }),
                serviceLifetime);
            return services;
        }
    }
}
