using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Strona_Restauracja.Entities;
using Strona_Restauracja.Exceptions;
using Strona_Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strona_Restauracja.Service
{
    public interface IRestaurantService
    {
        int Create(CreateRestaurantDto dto);
        void Delete(int id);
        IEnumerable<RestaurantDto> GetAll();
        RestaurantDto GetById(int id);
        void Update(int id, UpdateRestaurantDto dto);


    }

    public class RestaurantService : IRestaurantService
    {
        private readonly RestaurantDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly ILogger<RestaurantService> _logger;

        public RestaurantService(RestaurantDbContext dbContext, IMapper mapper, ILogger<RestaurantService> logger)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _logger = logger;
        }
        public void Update(int id, UpdateRestaurantDto dto)
        {
            var resturant = _dbContext
                .Restaurants
                .FirstOrDefault(r => r.Id == id);
            if (resturant is null)
                throw new NotFoundException("Restaurant not found");
            resturant.Name = dto.Name;
            resturant.Description = dto.Description;
            resturant.HasDelivery = dto.HasDelivery;
            _dbContext.SaveChanges();
            

        }
        public void Delete(int id)
        {
            _logger.LogError($"Restaurant with id: {id} delete action invoked");
            var resturant = _dbContext
                .Restaurants
                .FirstOrDefault(r => r.Id == id);
            if (resturant is null) throw new NotFoundException("Restaurant not found");
            _dbContext.Restaurants.Remove(resturant);
            _dbContext.SaveChanges();
            

        }
        public RestaurantDto GetById(int id)
        {
            var resturant = _dbContext
            .Restaurants
            .Include(r => r.Address)
            .Include(r => r.Dishes)
            .FirstOrDefault(r => r.Id == id);

            if (resturant is null) throw new NotFoundException("Restaurant not found");
            var result = _mapper.Map<RestaurantDto>(resturant);
            return result;
        }
        public IEnumerable<RestaurantDto> GetAll()
        {
            var restaurants = _dbContext
                .Restaurants
                .Include(r => r.Address)
                .Include(r => r.Dishes)
                .ToList();
            var restaurantsDtos = _mapper.Map<List<RestaurantDto>>(restaurants);
            return restaurantsDtos;
        }
        public int Create(CreateRestaurantDto dto)
        {
            var restaurant = _mapper.Map<Restaurant>(dto);
            _dbContext.Restaurants.Add(restaurant);
            _dbContext.SaveChanges();

            return restaurant.Id;
        }
        
    }
}
