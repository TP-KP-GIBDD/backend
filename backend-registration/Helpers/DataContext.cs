using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Registration.Entities;

namespace Registration.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Data> Data { get; set; }
        
        private readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // подключение к sqlserver БД
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }
    }
}