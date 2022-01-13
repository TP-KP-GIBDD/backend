using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace FineAPI.Entities
{
    public class FineContext : DbContext
    {
        public FineContext(DbContextOptions<FineContext> options)
            : base(options)
        {
        }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<TypeFine> TypeFines { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<TypeFine>().HasData(
                new TypeFine[]
                {
                    new TypeFine{ id=1, Name = "Вождение в нетрезвом виде", Article = "264.1"},
                    new TypeFine{ id=2, Name = "Превышение скорости", Article = "12.9"},
                    new TypeFine{ id=3, Name = "Парковка в неположеном месте", Article = "124.2"}
                }
            );

            builder.Entity<Fine>().HasData(
                new Fine[]
                {
                    new Fine{Id = 1, PersonId = 6, AvtoId = 1, TypeFineId = 1, SumaryFine = 30000, StatusFine = "Не оплачен"},
                    new Fine{Id = 2, PersonId = 7, AvtoId = 2, TypeFineId = 2, SumaryFine = 500, StatusFine = "Не оплачен"},
                    new Fine{Id = 3, PersonId = 7, AvtoId = 1, TypeFineId = 3, SumaryFine = 1500, StatusFine = "Не оплачен"}
                }
            );
           
        }
    }
}
