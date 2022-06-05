using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace Data.Connect
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<Supervisor> Supervisor { get; set; }
        public DbSet<Role> Roles { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                "Data Source=productsTest.db");
            optionsBuilder.UseLazyLoadingProxies();
            SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_e_sqlite3());
        }
    }
}
