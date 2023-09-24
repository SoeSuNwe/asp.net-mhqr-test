using System;
using Microsoft.EntityFrameworkCore; 
using Task = TaskManager2.Models.Task;

namespace TaskManager2
{ 
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Task> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=app.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Task> tasks = new List<Task>();
            for (int i = 1; i <= 10; i++)
            {
                tasks.Add(
                    new Task
                    {
                        TaskId = i,
                        Title = "Tesk " + i,
                        Description = "This is Task " + i,
                        DueDate = DateTime.Now,
                        IsCompleted = true
                    }
                );
            }
            modelBuilder.Entity<Task>().HasData(tasks);
        }

    }
}
