using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strona_Restauracja.Entities
{
    public class RestaurantDbContext : DbContext
    {
        private string _connectionString =
            "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=RestaurantDB;Integrated Security=True;";
        public DbSet<Restaurant> Restaurants { get; set; } //Tabele ktore pojawia sie w bazie danych
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Dish> Dishes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) //Dodatkowa konfiguracja 
        {
            modelBuilder.Entity<Restaurant>()
                .Property(r => r.Name)
                .IsRequired()
                .HasMaxLength(25);

            modelBuilder.Entity<Dish>()
                .Property(d => d.Name)
                .IsRequired();

            modelBuilder.Entity<Address>()
                .Property(a => a.City)
                .IsRequired()
                .HasMaxLength(50);
            
            modelBuilder.Entity<Address>()
                .Property(a => a.Street)
                .IsRequired()
                .HasMaxLength(50);




        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //Połączenie do bazy danych i jak ma ono wygladać
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
