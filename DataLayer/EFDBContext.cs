using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public class EFDBContext : DbContext
    {
        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options) => Database.EnsureCreated();
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
