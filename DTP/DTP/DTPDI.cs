using DTP.Repositories;
using DTP.Repositories.Abstracts;
using DTP.Services;
using DTP.Services.Abstracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP
{
    public static class DTPDI
    {
        public static IServiceCollection AddDTPRepositoriesDI(this IServiceCollection services)
        {
            return services
                .AddTransient<IProtocolRepository, ProtocolRepository>();
        }

        public static IServiceCollection AddDTPServicesDI(this IServiceCollection services)
        {
            return services
                .AddScoped<IProtocolService, ProtocolService>();

        }
    }
}
