using Microsoft.EntityFrameworkCore;
using MihailTest.Models;

namespace MihailTest.Repositories
{
    public class StoreContext: DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public StoreContext(DbContextOptions options) : base(options) { }
      
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .HasIndex(p => p.Id)               
                .IsUnique();

            builder.Entity<Category>()
            .HasIndex(c => c.Id)
            .IsUnique();

            builder.Entity<Product>()
              .HasOne(p => p.Category)
              .WithMany(c=>c.Products)
              .OnDelete(DeleteBehavior.Cascade);
        }
      
        public DbSet<MihailTest.Models.Category> Category { get; set; }
    }
}
