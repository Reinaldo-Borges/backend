using DynamicSchool.Domain.Entities.Courses;
using DynamicSchool.Domain.Entities.People;
using DynamicSchool.Domain.Entities.Registrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Reflection;

namespace DynamicSchool.Infra.Data.infrastructure.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .EnableSensitiveDataLogging()
                .LogTo(Console.WriteLine, LogLevel.Information);
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //global filter
            //modelBuilder.Entity<Course>().HasQueryFilter(f => f.StatusEntity == Core.Enum.StatusEntityEnum.Active);
            //modelBuilder.Entity<Level>().HasQueryFilter(f => f.StatusEntity == Core.Enum.StatusEntityEnum.Active);
            //modelBuilder.Entity<Lesson>().HasQueryFilter(f => f.StatusEntity == Core.Enum.StatusEntityEnum.Active);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());  
                
        }

    }
}
