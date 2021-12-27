using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Snackis.Areas.Identity.Data;

namespace Snackis.Data
{
    public class SnackisContext : IdentityDbContext<SnackisUser>
    {
        public SnackisContext(DbContextOptions<SnackisContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            const string USER_ID = "a18be9c0-aa65-4af8-bd17-00bd9344e575";
            const string ADMIN_ID = "d620577c-7da0-4402-ba85-d4ff973026ef";

            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = USER_ID, Name = "User", NormalizedName = "USER".ToUpper() });
            builder.Entity<IdentityRole>().HasData(new IdentityRole { Id = ADMIN_ID, Name = "Admin", NormalizedName = "ADMIN".ToUpper() });

            var hasher = new PasswordHasher<SnackisUser>();

            builder.Entity<SnackisUser>().HasData(new SnackisUser
            {   //ADMINACCOUNT
                Id = "359c3681-f907-4610-87a9-2486af4bc77c",
                Email = "admin@test.com",
                EmailConfirmed = true,
                NormalizedEmail = "ADMIN@TEST.COM".ToUpper(),
                PasswordHash = hasher.HashPassword(null, "Password123!"),
                UserName = "Admin",
                NormalizedUserName = "ADMIN".ToUpper(),
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = ADMIN_ID, UserId = "359c3681-f907-4610-87a9-2486af4bc77c" });

            builder.Entity<SnackisUser>().HasData(new SnackisUser
            {   //DUMMYUSER #1
                Id = "8e176796-8d11-4227-8c4f-7bf91fe40e85",
                Email = "annika@test.com",
                EmailConfirmed = true,
                NormalizedEmail = "ANNIKA@TEST.COM".ToUpper(),
                PasswordHash = hasher.HashPassword(null, "Password123!"),
                UserName = "Annika100",
                NormalizedUserName = "ANNIKA100".ToUpper(),
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = USER_ID, UserId = "8e176796-8d11-4227-8c4f-7bf91fe40e85" });

            builder.Entity<SnackisUser>().HasData(new SnackisUser
            {   //DUMMYUSER #2
                Id = "e3560fc0-d450-404f-bb0b-24ac07f63c2a",
                Email = "Johanna@test.com",
                EmailConfirmed = true,
                NormalizedEmail = "JOHANNA@TEST.COM".ToUpper(),
                PasswordHash = hasher.HashPassword(null, "Password123!"),
                UserName = "Johanna1337",
                NormalizedUserName = "JOHANNA1337".ToUpper(),
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = USER_ID, UserId = "e3560fc0-d450-404f-bb0b-24ac07f63c2a" });

            builder.Entity<SnackisUser>().HasData(new SnackisUser
            {   //DUMMYUSER #3
                Id = "e447eb5a-8253-49ba-83bb-2d2b0614672d",
                Email = "tommy@test.com",
                EmailConfirmed = true,
                NormalizedEmail = "TOMMY@TEST.COM".ToUpper(),
                PasswordHash = hasher.HashPassword(null, "Password123!"),
                UserName = "Tommy4life",
                NormalizedUserName = "TOMMY4LIFE".ToUpper(),
            });
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { RoleId = USER_ID, UserId = "e447eb5a-8253-49ba-83bb-2d2b0614672d" });
        }
    }
}
