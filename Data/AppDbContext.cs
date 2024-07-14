using CrudWithPostgreSQL.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudWithPostgreSQL.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Item> Items { get; set; }
    }
}

