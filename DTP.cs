using DTP.Repositories;
using DTP.Repositories.Abstracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP
{
    public static class DTP
    {
        public static IServiceCollection AddDTPrepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IPlaceViolationRepository, PlaceViolationRepository>()
                .AddScoped<IParticipantsRepository, ParticipantsRepository>()
                .AddScoped<IProtocolRepository, ProtocolRepository>()
                .AddScoped<ITypeViolationRepository, TypeViolationRepository>();
        }
    }
}
