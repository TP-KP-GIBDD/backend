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
                    new GibddOffice{Id = 2, Name = "Отдел ГИБДД по Суздальскому району", RegionId = 1, Lat=57.434, Lon=55.432},
                    new GibddOffice{Id = 3, Name = "Отделение регистрации МО ГИБДД ТНРЭР № 1 ГУ МВД России по г. Москве", RegionId = 2, Lat=55.898286, Lon=37.516979},
                    new GibddOffice{Id = 4, Name = "Управление ГИБДД ГУ МВД России по городу Москве", RegionId = 2, Lat=55.773798, Lon=37.612227},
                    new GibddOffice{Id = 5, Name = "ОБ ДПС ГИБДД УВД по ЮВАО ГУ МВД России по г. Москве", RegionId = 2, Lat=55.675286, Lon=37.727239},
                    new GibddOffice{Id = 6, Name = "Управление ГИБДД по г. Иваново", RegionId = 3, Lat=57.000353, Lon=40.97393},
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

            builder.Entity<ServiceDateTime>().HasData(
                new ServiceDateTime { Id = 1, Date = new DateTime(2021, 12, 7), Time="8:00", IsFree=true },
                new ServiceDateTime { Id = 2, Date = new DateTime(2021, 12, 7), Time="8:15", IsFree = true },
                new ServiceDateTime { Id = 3, Date = new DateTime(2021, 12, 7), Time = "8:30", IsFree = true },
                new ServiceDateTime { Id = 4, Date = new DateTime(2021, 12, 7), Time = "8:45", IsFree = false },
                new ServiceDateTime { Id = 5, Date = new DateTime(2021, 12, 7), Time = "9:00", IsFree = true },
                new ServiceDateTime { Id = 6, Date = new DateTime(2021, 12, 7), Time = "9:15", IsFree = true },
                new ServiceDateTime { Id = 7, Date = new DateTime(2021, 12, 7), Time = "9:30", IsFree = true },
                new ServiceDateTime { Id = 8, Date = new DateTime(2021, 12, 7), Time = "9:45", IsFree = true },
                new ServiceDateTime { Id = 9, Date = new DateTime(2021, 12, 7), Time = "10:00", IsFree = true },
                new ServiceDateTime { Id = 10, Date = new DateTime(2021, 12, 7), Time = "10:15", IsFree = true },
                new ServiceDateTime { Id = 11, Date = new DateTime(2021, 12, 7), Time = "10:30", IsFree = true },
                new ServiceDateTime { Id = 12, Date = new DateTime(2021, 12, 7), Time = "10:45", IsFree = true },
                new ServiceDateTime { Id = 13, Date = new DateTime(2021, 12, 7), Time = "11:00", IsFree = true },
                new ServiceDateTime { Id = 14, Date = new DateTime(2021, 12, 7), Time = "11:15", IsFree = true },
                new ServiceDateTime { Id = 15, Date = new DateTime(2021, 12, 7), Time = "11:30", IsFree = true },
                new ServiceDateTime { Id = 16, Date = new DateTime(2021, 12, 7), Time = "11:45", IsFree = true },
                new ServiceDateTime { Id = 17, Date = new DateTime(2021, 12, 7), Time = "12:00", IsFree = true },
                new ServiceDateTime { Id = 18, Date = new DateTime(2021, 12, 7), Time = "13:00", IsFree = true },
                new ServiceDateTime { Id = 19, Date = new DateTime(2021, 12, 7), Time = "13:15", IsFree = true },
                new ServiceDateTime { Id = 20, Date = new DateTime(2021, 12, 7), Time = "13:30", IsFree = true },
                new ServiceDateTime { Id = 21, Date = new DateTime(2021, 12, 7), Time = "13:45", IsFree = true },
                new ServiceDateTime { Id = 22, Date = new DateTime(2021, 12, 7), Time = "14:00", IsFree = true },
                new ServiceDateTime { Id = 23, Date = new DateTime(2021, 12, 7), Time = "14:15", IsFree = true }
            );
        }
    }
}
