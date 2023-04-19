using KPE.Framework.Extension;
using KPE.Repository.Implementaion;
using KPE.Repository.Infrastructure;
using KPE.Repository.Infrastructure.Interface;
using KPE.Repository.Interface;
using KPE.Service.Implementation;
using KPE.Service.Interface;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPE.DependencyInjection
{
    public static class ServiceRegistration
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IEstimationService, EstimationService>();
            services.AddScoped<IEstimationRepository, EstimationRepository>();
        }
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSettingsProvider(configuration);
            services.AddTransient<IQueryBuilder, SqlQueryBuilder>();
            //services.AddTransient<ISettingsService, SettingsService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IConnectionFactory, SqlConnectionFactory>();
        }
    }
}
