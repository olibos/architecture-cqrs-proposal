﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewArchi.Services;

#nullable disable

namespace NewArchi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230330134426_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("NewArchi.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Fullname = "Olivier Bossaer",
                            PasswordHash = "$argon2id$v=19$m=65536,t=3,p=1$Y0u6/jsrbMM23wnJgRcyGQ$uTyk69zcFVn4EBjS9QXBg4Pl8e6/YixVFHwkyRb1wTw",
                            Username = "olibos"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
