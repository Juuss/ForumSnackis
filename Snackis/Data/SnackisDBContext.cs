using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Snackis.Models;

namespace Snackis.Data
{
    public class SnackisDBContext : DbContext
    {
        public DbSet<ChattMessage> ChattMessages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Post> Posts { get; set; }
        public SnackisDBContext(DbContextOptions<SnackisDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Kategorier
            builder.Entity<Category>().HasData(new Category { Id = 1, CategoryName = "Djur" });
            builder.Entity<Category>().HasData(new Category { Id = 2, CategoryName = "Sport" });
            builder.Entity<Category>().HasData(new Category { Id = 3, CategoryName = "Fordon" });

            //Underkategorier
            builder.Entity<SubCategory>().HasData(new SubCategory { Id = 1, SubCatName = "Hundar", CategoryID = 1 });
            builder.Entity<SubCategory>().HasData(new SubCategory { Id = 2, SubCatName = "Katter", CategoryID = 1 });
            builder.Entity<SubCategory>().HasData(new SubCategory { Id = 3, SubCatName = "Hästar", CategoryID = 1 });
            builder.Entity<SubCategory>().HasData(new SubCategory { Id = 4, SubCatName = "Fotboll", CategoryID = 2 });
            builder.Entity<SubCategory>().HasData(new SubCategory { Id = 5, SubCatName = "Golf", CategoryID = 2 });
            builder.Entity<SubCategory>().HasData(new SubCategory { Id = 6, SubCatName = "Cykling", CategoryID = 2 });
            builder.Entity<SubCategory>().HasData(new SubCategory { Id = 7, SubCatName = "Bilar", CategoryID = 3 });
            builder.Entity<SubCategory>().HasData(new SubCategory { Id = 8, SubCatName = "Båtar", CategoryID = 3 });
            builder.Entity<SubCategory>().HasData(new SubCategory { Id = 9, SubCatName = "Motorcyklar", CategoryID = 3 });
        }
    }
}
