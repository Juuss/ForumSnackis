using Microsoft.EntityFrameworkCore;
using Snackis.Models;

namespace Snackis.Data
{
    public class SubCatDBContext : DbContext
    {
        public DbSet<SubCategory> SubCategories { get; set; }
        public SubCatDBContext(DbContextOptions<SubCatDBContext> options) : base(options)
        {
        }
    }
}
