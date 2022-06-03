using Microsoft.EntityFrameworkCore;

namespace TodoListApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().HasData(
                new TodoItem() { Id = 1, IdDone = true, Title="Do your homework" },
                new TodoItem() { Id = 2, IdDone = false, Title = "Do fitness" },
                new TodoItem() { Id = 3, IdDone = false, Title = "Call you parents" },
                new TodoItem() { Id = 4, IdDone = true, Title = "Clean your room" }
                );
        }
    }
}
