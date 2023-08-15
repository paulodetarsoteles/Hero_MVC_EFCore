using Hero_MVC_EFCore.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Hero_MVC_EFCore.DAL.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<SecretIdentity> SecretIdentities { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<FilmsHeroes> FilmsHeroes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmsHeroes>
            (entity => { entity.HasKey(e => new { e.FilmId, e.HeroId }); });
        }
    }
}
