using Microsoft.EntityFrameworkCore;

namespace LoginForm.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-S9VDQ6Q1;Database=LOGINAPPDB;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}