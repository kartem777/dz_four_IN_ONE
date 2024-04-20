using Microsoft.EntityFrameworkCore;

namespace dz_four_IN_ONE
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Team> Tournament { get; set; } = null!;
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=dzmulti.db");
        }
    }
}