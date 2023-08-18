using K2BlogApp.Entity.Entities;
using Microsoft.EntityFrameworkCore;

namespace K2BlogApp.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
    }
}
