using FineAPI.Repositories;
using FineAPI.Repositories.Abstract;
using FineAPI.Services;
using FineAPI.Services.Abstract;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI
{
    public static class FineDI
    {
        public static IServiceCollection AddFineRepositoriesDI(this IServiceCollection services)
        {
            return services
                .AddTransient<IFineRepository, FineRepository>()
                .AddTransient<ITypeFineRepository, TypeFineRepository>();
        }

        public static IServiceCollection AddFineServicesDI(this IServiceCollection services)
        {
            return services
                .AddScoped<IFineService, FineService>()
                .AddScoped<ITypeFineService, TypeFineService>()
                .AddScoped<IEmailSendService, EmailSendService>();
        }
    }
}
