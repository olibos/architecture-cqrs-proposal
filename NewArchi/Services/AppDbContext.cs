namespace NewArchi.Services;

using System.Xml;

using Isopoh.Cryptography.Argon2;

using Microsoft.EntityFrameworkCore;

using NewArchi.Domain.Entities;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=mydatabase.db");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var userEntity = modelBuilder.Entity<User>();
        userEntity.HasKey(user => user.Id);
        userEntity.HasIndex(user => user.Username).IsUnique();
        userEntity.Property(user => user.Username).IsRequired();
        userEntity.Property(user => user.Fullname).IsRequired();
        userEntity.Property(user => user.PasswordHash).IsRequired();
        userEntity.HasData(
            new User
            {
                Id = 1,
                Username = "olibos",
                Fullname = "Olivier Bossaer",
                PasswordHash = Argon2.Hash("Bos"),
            });
    }
}
