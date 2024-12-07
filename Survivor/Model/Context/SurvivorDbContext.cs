using Microsoft.EntityFrameworkCore;
using Survivor.Model.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Survivor.Model.Context
{
    public class SurvivorDbContext : DbContext
    {
        public DbSet<Competitor> Competitors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configure the connection string
            optionsBuilder.UseSqlServer("Server=localhost;initial Catalog=SurvivorDb;integrated Security=true;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the one-to-many relationship
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Competitors)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
