using Microsoft.EntityFrameworkCore;
using lab.Models;

namespace lab.DB
{

    public class appDBcontext: DbContext
    {
        public appDBcontext(DbContextOptions<appDBcontext> cock):base(cock)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().ToTable("ToDoTable");
        }
        public DbSet<ToDoItem> ToDoTable { get; set; }
    }
}
