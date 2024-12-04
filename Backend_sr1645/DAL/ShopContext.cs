using Backend_sr1645.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_sr1645.DAL
{
    public class ShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ShopContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product() { Id=1, Name="pomidor", Price=5.6f },
                new Product() { Id=2, Name="ziemniaki", Price=2.6f },
                new Product() { Id=3, Name="ogórek", Price=6.2f },
                new Product() { Id=4, Name="kalafior", Price=10.6f },
                new Product() { Id=5, Name="brokuł", Price=8.9f },
                new Product() { Id=6, Name="cukinia", Price=7.99f }
                );
        }
    }
}
