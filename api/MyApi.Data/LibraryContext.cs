using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyApi.Data.Entities;
using Npgsql;

namespace MyApi.Data
{
    public class LibraryContext : DbContext
    {
        private static readonly ILoggerFactory MyLoggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
        });

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookReview> BookReviews { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new NpgsqlConnectionStringBuilder
            {
                Host = Environment.GetEnvironmentVariable("DB_HOST") ?? "",
                Database = Environment.GetEnvironmentVariable("DB_DATABASE") ?? "",
                Username = Environment.GetEnvironmentVariable("DB_USERNAME") ?? "",
                Password = Environment.GetEnvironmentVariable("DB_PASSWORD") ?? ""
            };

            optionsBuilder.UseNpgsql(builder.ConnectionString);

            optionsBuilder.UseLoggerFactory(MyLoggerFactory);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);

            modelBuilder.Entity<Author>().HasData(SeedData.Data.Select(x => x.Item1));
            modelBuilder.Entity<Book>().HasData(SeedData.Data.SelectMany(x => x.Item2));
        }
    }
}
