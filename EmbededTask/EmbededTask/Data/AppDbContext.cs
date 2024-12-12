using EmbededTask.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmbededTask.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
