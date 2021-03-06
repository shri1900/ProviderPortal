﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portal.API.Data;

namespace Portal.API.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024");

            modelBuilder.Entity("Portal.API.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RoleName");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Portal.API.Models.RolePermission", b =>
                {
                    b.Property<int>("RolePermissionId")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("HomePage");

                    b.Property<bool>("Page1");

                    b.Property<bool>("Page2");

                    b.Property<bool>("Page3");

                    b.Property<bool>("Page4");

                    b.Property<bool>("Page5");

                    b.Property<bool>("Page6");

                    b.Property<bool>("Page7");

                    b.Property<bool>("Page8");

                    b.Property<bool>("Page9");

                    b.Property<int>("RoleRefId");

                    b.HasKey("RolePermissionId");

                    b.HasIndex("RoleRefId")
                        .IsUnique();

                    b.ToTable("RolePermission");
                });

            modelBuilder.Entity("Portal.API.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<int>("RoleId");

                    b.Property<string>("Username");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Portal.API.Models.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRole");
                });

            modelBuilder.Entity("Portal.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Value");
                });

            modelBuilder.Entity("Portal.API.Models.RolePermission", b =>
                {
                    b.HasOne("Portal.API.Models.Role", "Role")
                        .WithOne("RolePermission")
                        .HasForeignKey("Portal.API.Models.RolePermission", "RoleRefId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Portal.API.Models.UserRole", b =>
                {
                    b.HasOne("Portal.API.Models.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Portal.API.Models.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
