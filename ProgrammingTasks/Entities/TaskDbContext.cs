using Microsoft.EntityFrameworkCore;

namespace ProgrammingTasks.Entities
{
    public class TaskDbContext : DbContext
    {
        private string _connectionString = "Server=DESKTOP-MRFM23R;Database=ProgrammingTasksDb;Trusted_Connection=True;";
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Task>()
                .Property(t => t.Description)
                .IsRequired();

            modelBuilder.Entity<Test>()
                .Property(t => t.Input)
                .IsRequired();
            modelBuilder.Entity<Test>()
                .Property(t => t.ExpectedOutput)
                .IsRequired();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
