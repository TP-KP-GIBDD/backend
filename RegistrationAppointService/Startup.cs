using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RegistrationAppointService.Models;
using RegistrationAppointService.Repositories.Interfaces;
using RegistrationAppointService.Repositories.Implimentation;
using RegistrationAppointService.Services.Interfaces;
using RegistrationAppointService.Services;
using RegistrationAppointService.Services.Implimentation;

namespace RegistrationAppointService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddControllers();

            services.AddCors(options => options.AddDefaultPolicy(
                    builder => builder.AllowAnyOrigin()
                ));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RegistrationAppointService", Version = "v1" });
            });

            services.AddDbContext<AppDBContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<IRepository<Region, int>, RegionRepository>();
            services.AddTransient<IRepository<GibddOffice, int>, GibddOfficeRepository>();
            services.AddTransient<IRepository<Service, int>, ServiceRepository>();
            services.AddTransient<IRegionOfficeService<int>, RegionOfficeService>();
            services.AddTransient<IDateTimeService, DateTimeService>();
            services.AddTransient<IRegAppointService, RegAppointService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "RegistrationAppointService v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors(builder => {
                builder.AllowAnyOrigin();
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
            });

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
