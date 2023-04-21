using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CIT242FinalProj.mvc.Models;

namespace CIT242FinalProj.mvc.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
	: base(options)
{
Database.EnsureCreated();
}
        public DbSet<Users> Users { get; set; }
        public DbSet<Tasks> Tasks {get; set; }
        public DbSet<Scoreboard> Scoreboard {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../FinalProj2.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("Users");
            modelBuilder.Entity<Tasks>().ToTable("Tasks");
            modelBuilder.Entity<Scoreboard>().ToTable("Scoreboard");
        }
    }
