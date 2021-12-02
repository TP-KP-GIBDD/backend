using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RegistrationAppointService.Models
{
    public class AppDBContext : DbContext
    {
        public DbSet<RegistrationService> RegistrationServices { get; set; }
        public DbSet<GibddOffice> GibddOffices { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<ServiceDateTime> ServiceDateTimes { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<Region>().HasData(
                new Region[]
                {
                    new Region{Id = 1, Name="Владимирская область", lat=56.129057, lon=40.406635},
                    new Region{Id = 2, Name="Московская область", lat=55.75322, lon=37.622513},
                    new Region{Id = 3, Name="Ивановская область", lat=57.000353, lon=40.97393}
                }
            );

            builder.Entity<GibddOffice>().HasData(
                new GibddOffice[]
                {
                    new GibddOffice{Id = 1, Name = "Управление ГИБДД УМВД России по Владимирской обл.", RegionId = 1, Lat=56.434, Lon=54.432},
                    new GibddOffice{Id = 2, Name = "Отдел ГИБДД по Суздальскому району", RegionId = 1, Lat=57.434, Lon=55.432}
                }
            );

            builder.Entity<Document>().HasData(
                new Document[]
                {
                    new Document{Id = 1, Name = "Паспорт гражданина РФ"},
                    new Document{Id = 2, Name = "Водительское удостоверение"},
                    new Document{Id = 3, Name = "Документ о сдаче экзамена ПДД"},
                    new Document{Id = 4, Name = "Договор купли-продажи транспортного средства"},
                    new Document{Id = 5, Name = "Страховой полис"},
                    new Document{Id = 6, Name = "Технический паспорт транспортного средства"},
                    new Document{Id = 7, Name = "Документ собственника транспортного средства"},
                }
            );

            builder.Entity<Service>().HasData(
                new Service { Id = 1, Name = "Постановка автомобиля на учёт" },
                new Service { Id = 2, Name = "Получение водительского удостоверения" },
                new Service { Id = 3, Name = "Замена водительского удостоверения" }
            );
        }
    }
}
