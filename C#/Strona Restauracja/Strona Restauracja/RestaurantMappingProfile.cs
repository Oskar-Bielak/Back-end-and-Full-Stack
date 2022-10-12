using AutoMapper;
using Strona_Restauracja.Entities;
using Strona_Restauracja.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strona_Restauracja
{
    public class RestaurantMappingProfile : Profile
    {
        public RestaurantMappingProfile()
        {
            CreateMap<Restaurant, RestaurantDto>()
              .ForMember(m => m.City, c => c.MapFrom(s => s.Address.City))
              .ForMember(m => m.Street, c => c.MapFrom(s => s.Address.Street))
              .ForMember(m => m.PostalCode, c => c.MapFrom(s => s.Address.PostalCode));
            CreateMap<Dish, DishDto>();
        }
    }
}
