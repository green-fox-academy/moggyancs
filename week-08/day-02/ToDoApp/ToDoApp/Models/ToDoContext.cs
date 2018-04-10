using Microsoft.EntityFrameworkCore;
using ToDoApp.Models;

namespace ToDoApp
{
    public class ToDoContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        public ToDoContext(DbContextOptions options) : base(options)
        {

        }

    }
}
