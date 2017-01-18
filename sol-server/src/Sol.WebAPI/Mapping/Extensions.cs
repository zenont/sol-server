using Microsoft.Extensions.DependencyInjection;

namespace Sol.WebAPI.Mapping
{
    public static class Extensions
    {
        public static void AddAutomapperWithSolMappings(this IServiceCollection services)
        {
            var mapper = AutomapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
