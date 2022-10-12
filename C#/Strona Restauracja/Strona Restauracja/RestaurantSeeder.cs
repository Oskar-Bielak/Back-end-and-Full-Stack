using Strona_Restauracja.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strona_Restauracja
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbContext _dbContext;
        public RestaurantSeeder(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (_dbContext.Database.CanConnect()) // Sprawdzenie połaczenia
            {
                if (!_dbContext.Restaurants.Any()) //Sprawdzenie czy baza jest pusta
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                    _dbContext.SaveChanges(); //Zapisywanie do Bazy danych
                }
            }
        }
        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name ="KFC",
                    Category = "Fast Food",
                    Description =" KFC (Short for Kentucky Chicken) is an American fast food",
                    ContactEmali = "contact@kfc.com",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "Nashville Hot Chicken",
                            Price =10.30M,
                        },
                        new Dish()
                        {
                            Name = "Chicekn Nuugets",
                            Price =5.30M,
                        },
                    },
                    Address = new Address()
                    {
                        City ="Kraków",
                        Street="Długa 5",
                        PostalCode ="30-001"
                    }

                }, // Dodanie restauracji
                

            };
            return restaurants;
        }
    }

}
