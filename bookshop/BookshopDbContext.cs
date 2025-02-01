using bookshop.DbModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;

namespace bookshop
{
    public class BookshopDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }  

        public BookshopDbContext(DbContextOptions<BookshopDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>()
                .Property(u => u.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Login).IsUnique();
        }
    }
}
