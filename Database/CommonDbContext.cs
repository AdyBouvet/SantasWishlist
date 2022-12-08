using Azure.Core;
using Azure.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SantasWishlist.Models;

namespace SantasWishlist.Database
{
    public class CommonDbContext : DbContext
    {
        public CommonDbContext(DbContextOptions<CommonDbContext> options) : base(options)
        {
            var conn = (SqlConnection)Database.GetDbConnection();
            var tokenCredential = new DefaultAzureCredential();
            conn.AccessToken = tokenCredential.GetToken(
                new TokenRequestContext(new[] { "https://database.windows.net/.default" })).Token;
        }

        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasKey("Id");
        }
    }
}
