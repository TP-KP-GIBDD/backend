using Microsoft.EntityFrameworkCore;

namespace DTP.Entities
{
    public class ProtocolContext : DbContext
    {
        public ProtocolContext(DbContextOptions<ProtocolContext> options) : base(options)
        {
            
        }
        public DbSet<Participants> Participants { get; set; }
        public DbSet<PlaceViolation> PlaceViolation { get; set; }
        public DbSet<Protocol> Protocols { get; set; }
        public DbSet<TypeViolation> TypeViolations { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            builder.Entity<TypeViolation>().HasData(
                new TypeViolation[]
                {
                    new TypeViolation{ Id=1, Name = "столкновение транспортных средств"},
                    new TypeViolation{ Id=2, Name = "наезд на припятствие"},
                    new TypeViolation{ Id=3, Name = "опрокидывание/съезд в кювет"},
                    new TypeViolation{ Id=4, Name = "наезд на пешехода"},
                    new TypeViolation{ Id=5, Name = "наезд на животное"},
                    new TypeViolation{ Id=6, Name = "другое"}
                });
        }
    }
}
