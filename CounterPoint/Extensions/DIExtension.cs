using Business.Abstract;
using Business.Services;
using Repository.Core;
using Repository.Persistence;

namespace CounterPoint.Extensions
{
    public static class DIExtension
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserActivityService, UserActivityService>();
            services.AddScoped<IWebEmtService, WebEmtService>();
            services.AddScoped<ISpotService, SpotService>();
            return services;
        }
    }
}
