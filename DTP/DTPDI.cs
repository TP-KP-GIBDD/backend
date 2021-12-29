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
        public static IServiceCollection AddAvtoRepositoriesDI(this IServiceCollection services)
        {
            return services
                .AddTransient<ICoordinatesRepository, CoordinatesRepository>()
                .AddTransient<IParticipantsRepository, ParticipantsRepository>()
                .AddTransient<IPlaceViolationRepository, PlaceViolationRepository>()
                .AddTransient<IProtocolRepository, ProtocolRepository>()
                .AddTransient<ITypeViolationRepository, TypeViolationRepository>();
        }

        public static IServiceCollection AddAvtoServicesDI(this IServiceCollection services)
        {
            return services
                .AddScoped<ICoordinatesService, CoordinatesService>()
                .AddScoped<IParticipantsService, ParticipantsService>()
                .AddScoped<IPlaceViolationService, PlaceViolationService>()
                .AddScoped<IProtocolService, ProtocolService>()
                .AddScoped<ITypeViolationService, TypeViolationService>();
        }
    }
}
