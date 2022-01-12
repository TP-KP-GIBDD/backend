using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvtoAPI.Entities;

namespace AvtoAPI.Entities
{
    public class AvtoContext : DbContext
    {
        public AvtoContext(DbContextOptions<AvtoContext> options)
            : base(options)
        {
        }
        public DbSet<Avto> Avtos { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }
        public DbSet<Rudder> Rudders { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<BrandModel> BrandModel { get; set; }
        public DbSet<ColorAvto> ColorAvto { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<Brand>().HasData(
                new Brand[]
                {
                    new Brand{ Id=1, Name = "Mercedes"},
                    new Brand{ Id=2,Name = "BMW"},
                    new Brand{ Id=3,Name="KIA"}
                });
            builder.Entity<BrandModel>().HasData(
                new BrandModel[]
                {
                    new BrandModel{ Id=1,Name = "c63", BrandId = 1},
                    new BrandModel{ Id=2,Name = "m5", BrandId = 2},
                    new BrandModel{ Id=3,Name="k5", BrandId = 3}
                });
            builder.Entity<ColorAvto>().HasData(
                new ColorAvto[]
                {
                    new ColorAvto{ Id=1,Name = "Синий"},
                    new ColorAvto{ Id=2,Name = "Красный"},
                    new ColorAvto{ Id=3,Name="Белый"}
                });
            builder.Entity<Rudder>().HasData(
                new Rudder[]
                {
                    new Rudder{ Id=1,Name = "Левый"},
                    new Rudder{ Id=2,Name = "Правый"},
                });
            builder.Entity<BodyType>().HasData(
                new BodyType[]
                {
                    new BodyType{ Id=1,Name = "Седан"},
                    new BodyType{ Id=2,Name = "Хэтчбэк"},
                    new BodyType{ Id=3,Name="Купе"}
                });
            builder.Entity<CarOwner>().HasData(
                new CarOwner[]
                {
                    new CarOwner{ Id=1,PersonId = 1, AvtoId = 1},
                    new CarOwner{ Id=2,PersonId = 2, AvtoId = 2},
                    new CarOwner{ Id=3,PersonId = 3, AvtoId = 3}
                });
            builder.Entity<Avto>().HasData(
            new Avto[]
            {
                new Avto{ Id=1,BodyTypeId = 1, BrandModelId = 1, ColorId = 1, RudderId = 1, NumberAvto = "1", Year = 2001, Vin = "1111111111", Power = 111, PersonId = 1},
                new Avto{ Id=2,BodyTypeId = 2, BrandModelId = 2, ColorId = 2, RudderId = 2, NumberAvto = "2", Year = 2002, Vin = "2211111111", Power = 222, PersonId = 1},
                new Avto{ Id=3,BodyTypeId = 3, BrandModelId = 3, ColorId = 3, RudderId = 1, NumberAvto = "3", Year = 2003, Vin = "3311111111", Power = 333, PersonId = 2}
            });
        }
    }
}
