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