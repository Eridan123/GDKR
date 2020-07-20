using Gkdr.Consumer.Data.AppModel;
using Microsoft.EntityFrameworkCore;

namespace Gkdr.Consumer.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<GDKRLog> GDKRLogs{ get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder) { }
    }
}
