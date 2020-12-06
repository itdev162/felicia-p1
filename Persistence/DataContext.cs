using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DbSet <Value> Values { get; set;}
        public DbSet<Restaurant> Restaurants {get; set;}

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Value>().HasData(
                new Restaurant {Id = 1, Category= "Burgers", Name = "Bobs Burgers", Rating = 6},
                new Restaurant {Id = 2, Category = "Mexican", Name = "La Hacienda", Rating = 8},
                new Restaurant {Id = 3, Category = "Diner Classics", Name = "Mabels Diner", Rating = 9}
            );
        }
    }
}