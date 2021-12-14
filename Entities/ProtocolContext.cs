using Microsoft.EntityFrameworkCore;

namespace DTP.Entities
{
    public class ProtocolContext : DbContext
    {
        public ProtocolContext(DbContextOptions<ProtocolContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Participants> Participants { get; set; }
        public DbSet<PlaceViolation> PlaceViolation { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<TypeViolation> TypeViolations { get; set; }
    }
}
