using Microsoft.EntityFrameworkCore;
using ProjectWithRazorPages.Models;

namespace ProjectWithRazorPages.Data
{
    public class ProjectDbContext : DbContext
    {
        public DbSet<Category> Category { get; set; }

        public ProjectDbContext() {}
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasKey(c => c.Id);
        }
    }
}
