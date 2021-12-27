﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Snackis.Data;

namespace Snackis.Migrations
{
    [DbContext(typeof(SnackisContext))]
    [Migration("20211227163732_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                            ConcurrencyStamp = "bfc992d6-271d-4f2c-ba29-d2b4d55af088",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "d620577c-7da0-4402-ba85-d4ff973026ef",
                            ConcurrencyStamp = "90eed08f-39a0-4913-a876-041a82394e71",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "359c3681-f907-4610-87a9-2486af4bc77c",
                            RoleId = "d620577c-7da0-4402-ba85-d4ff973026ef"
                        },
                        new
                        {
                            UserId = "8e176796-8d11-4227-8c4f-7bf91fe40e85",
                            RoleId = "a18be9c0-aa65-4af8-bd17-00bd9344e575"
                        },
                        new
                        {
                            UserId = "e3560fc0-d450-404f-bb0b-24ac07f63c2a",
                            RoleId = "a18be9c0-aa65-4af8-bd17-00bd9344e575"
                        },
                        new
                        {
                            UserId = "e447eb5a-8253-49ba-83bb-2d2b0614672d",
                            RoleId = "a18be9c0-aa65-4af8-bd17-00bd9344e575"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Snackis.Areas.Identity.Data.SnackisUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "359c3681-f907-4610-87a9-2486af4bc77c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b099661-b969-4501-87b6-e4d06812fd8f",
                            Email = "admin@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@TEST.COM",
                            NormalizedUserName = "ADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEJeavqVzKbRLS4KqltViLdaPY7Am+lymYTbuK0hEmdTb8eYyXN1F5D7woMzWOsIydQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "24c901c8-0cd9-41d7-9af7-46f4000715ca",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = "8e176796-8d11-4227-8c4f-7bf91fe40e85",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d57ab0b8-819b-422c-aa81-9e88196d47d1",
                            Email = "annika@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "ANNIKA@TEST.COM",
                            NormalizedUserName = "ANNIKA100",
                            PasswordHash = "AQAAAAEAACcQAAAAEOWoygklwhful+5UgiF/A4XitwD/xZbsHDPDvGiXew0T+OclIM2jBNOKaT9F6s64qA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "63566637-cb9c-42a1-afaa-46de5d876227",
                            TwoFactorEnabled = false,
                            UserName = "Annika100"
                        },
                        new
                        {
                            Id = "e3560fc0-d450-404f-bb0b-24ac07f63c2a",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e334c783-3e4d-46b8-a11f-461011e3e81d",
                            Email = "Johanna@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "JOHANNA@TEST.COM",
                            NormalizedUserName = "JOHANNA1337",
                            PasswordHash = "AQAAAAEAACcQAAAAEMX7sldX7QTkfn+DHkRmhpXLH+N5YwgrH6NCK3a9MFEOhR20zAA3fkjgSA5ih6la1w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ea5bedf2-8b39-42df-a412-5f41923da6c8",
                            TwoFactorEnabled = false,
                            UserName = "Johanna1337"
                        },
                        new
                        {
                            Id = "e447eb5a-8253-49ba-83bb-2d2b0614672d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "5dacec24-02e1-496b-9d29-16fb1c51e7e5",
                            Email = "tommy@test.com",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "TOMMY@TEST.COM",
                            NormalizedUserName = "TOMMY4LIFE",
                            PasswordHash = "AQAAAAEAACcQAAAAEKG0W276aeeCjDZvl7MSO3Ya6hpHG4Fc0mvS1WK8B9Fmlf7Fnukwuv/ukTmNX5WIzQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fc49c03f-bd42-415a-8e75-f406c01191f9",
                            TwoFactorEnabled = false,
                            UserName = "Tommy4life"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Snackis.Areas.Identity.Data.SnackisUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Snackis.Areas.Identity.Data.SnackisUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Snackis.Areas.Identity.Data.SnackisUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Snackis.Areas.Identity.Data.SnackisUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
