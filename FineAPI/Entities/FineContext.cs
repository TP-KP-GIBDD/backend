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
    }
}
