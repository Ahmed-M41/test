namespace CodingWiki_DataAccess.Data
{
    using CodingWiki_Model.Models;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Genre> Genres { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            string connectionString = this.GetConnectionString();
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "Spider without duty", ISBN = "123ASD", Price = 10.99m },
                new Book { BookId = 2, Title = "Fortune of time", ISBN = "231DES", Price = 11.99m });

            var bookList = new Book[]
            {
                new Book { BookId = 3, Title = "Fake sunday", ISBN = "123ASD", Price = 20.99m },
                new Book { BookId = 4, Title = "Cookie jar", ISBN = "AS241", Price = 21.99m },
                new Book { BookId = 5, Title = "Cloudy forest", ISBN = "12D43", Price = 25.99m },
            };
            modelBuilder.Entity<Book>().HasData(bookList);
        }

        private string GetConnectionString()
        {
            string host = "localhost";
            string user = "root";
            string password = "P@ssw0rd";
            string dbName = "CodingWiki";
            return $"server={host};user id={user};password={password};port=3306;database={dbName};";
        }
    }
}