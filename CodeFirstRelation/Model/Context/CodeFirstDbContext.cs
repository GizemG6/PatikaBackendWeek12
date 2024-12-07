using CodeFirstRelation.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelation.Model.Context
{
    public class CodeFirstDbContext : DbContext
    {
        // Define the Users table
        public DbSet<User> Users { get; set; }

        // Define the Posts table
        public DbSet<Post> Posts { get; set; }

        // Configure database connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection string for SQL Server
            optionsBuilder.UseSqlServer("Server=GIZEM\\SQLEXPRESS;initial Catalog=PatikaSecondDbContext;integrated Security=true;TrustServerCertificate=true;");
        }

        // Configure relationships and constraints
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define the one-to-many relationship between User and Post
            modelBuilder.Entity<User>()
                .HasMany(u => u.Posts)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}
