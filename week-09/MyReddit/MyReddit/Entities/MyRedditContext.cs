using Microsoft.EntityFrameworkCore;
using MyReddit.Models;

namespace MyReddit.Entities
{
    public class MyRedditContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        public MyRedditContext(DbContextOptions options) : base(options)
        {

        }
    }


}
