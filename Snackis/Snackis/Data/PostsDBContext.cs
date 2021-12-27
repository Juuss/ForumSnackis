using Microsoft.EntityFrameworkCore;
using Snackis.Models;

namespace Snackis.Data
{
    public class PostsDBContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public PostsDBContext(DbContextOptions<PostsDBContext> options) : base(options)
        {
        }
    }
}
