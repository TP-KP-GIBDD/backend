using AvtoAPI.Repositories;
using AvtoAPI.Repositories.Abstracts;
using AvtoAPI.Services;
using AvtoAPI.Services.Abstracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI
{
    public static class AvtoDI
    {
        public static IServiceCollection AddAvtoRepositoriesDI(this IServiceCollection services)
        {
            return services
                .AddTransient<IAvtoRepository, AvtoRepository>()
                .AddTransient<IBodyTypeRepository, BodyTypeRepository>()
                .AddTransient<ICarOwnerRepository, CarOwnerRepository>()
                .AddTransient<IRudderRepository, RudderRepository>()
                .AddTransient<IBrandModelRepository, BrandModelRepository>()
                .AddTransient<IBrandRepository, BrandRepository>()
                .AddTransient<IColorAvtoRepository, ColorAvtoRepository>();
        }

        public static IServiceCollection AddAvtoServicesDI(this IServiceCollection services)
        {
            return services
                .AddScoped<IAvtoService, AvtoService>()
                .AddScoped<IBodyTypeService, BodyTypeService>()
                .AddScoped<ICarOwnerService, CarOwnerService>()
                .AddScoped<IRudderService, RudderService>()
                .AddScoped<IBrandService, BrandService>()
                .AddScoped<IBrandModelService, BrandModelService>()
                .AddScoped<IColorAvtoService, ColorAvtoService>();

        }
    }
}
