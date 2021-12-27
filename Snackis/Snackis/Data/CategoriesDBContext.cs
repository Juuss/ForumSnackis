using Microsoft.EntityFrameworkCore;
using Snackis.Models;
using Snackis.Data;

namespace Snackis.Data
{
    public class CategoriesDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public CategoriesDBContext(DbContextOptions<CategoriesDBContext> options): base(options)
        {
        }
        public DbSet<Snackis.Data.SubCategory> SubCategory { get; set; }
    }
}