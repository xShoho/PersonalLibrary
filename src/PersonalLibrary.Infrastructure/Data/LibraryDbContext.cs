using System;
using Microsoft.EntityFrameworkCore;
using PersonalLibrary.Core.Entities;

public class LibraryDbContext : DbContext
{
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public string DbPath { get; }

    public LibraryDbContext ()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "PersonalLibrary.db");
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Author>()
        .HasMany(e => e.Books)
        .WithOne(e => e.Author)
        .HasForeignKey(e => e.AuthorId)
        .HasPrincipalKey(e => e.Id);
    }
}