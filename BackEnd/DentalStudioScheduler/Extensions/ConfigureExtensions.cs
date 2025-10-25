using DentalStudioScheduler.Services;

namespace DentalStudioScheduler.Extensions
{
    public static class ConfigureExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<AppointmentService>();

            return services;
        }
    }
}
