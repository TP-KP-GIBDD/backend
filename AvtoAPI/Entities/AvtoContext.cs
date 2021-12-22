using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvtoAPI.Models;

namespace AvtoAPI.Entities
{
    public class AvtoContext : DbContext
    {
        public AvtoContext(DbContextOptions<AvtoContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Avto> Avtos { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<CarOwner> CarOwners { get; set; }
        public DbSet<Rudder> Rudders { get; set; }
      
    }
}
