using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hijacking.Entities
{
    public class HijackingContext : DbContext
    {
        public HijackingContext(DbContextOptions<HijackingContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<InfoResponceUser> infoResponceUsers { get; set; }
        public DbSet<Protocol> protocols { get; set; }
        public DbSet<ResponceUser> responceUsers { get; set; }
    }
}
