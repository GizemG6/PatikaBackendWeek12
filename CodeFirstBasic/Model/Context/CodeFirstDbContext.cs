using CodeFirstBasic.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstBasic.Model.Context
{
    public class CodeFirstDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; } // Movies table
        public DbSet<Game> Games { get; set; } // Games table

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection string
            optionsBuilder.UseSqlServer("Server=GIZEM\\SQLEXPRESS;initial Catalog=PatikaCodeFirstDb1;integrated Security=true;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Specifying table names with the Fluent API
            modelBuilder.Entity<Movie>().ToTable("Movies");
            modelBuilder.Entity<Game>().ToTable("Games");
        }
    }
}
