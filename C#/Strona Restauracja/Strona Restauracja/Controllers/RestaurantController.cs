using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Strona_Restauracja.Entities;
using Strona_Restauracja.Models;
using Strona_Restauracja.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Strona_Restauracja.Controllers
{
    [Route("api/restaurant")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantService _restaurantService;
        

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }
        [HttpPut("{id}")]
        public ActionResult Update([FromBody]UpdateRestaurantDto dto, [FromRoute] int id) // Metoda do zmiany danych w restauracji.
        {
            
             _restaurantService.Update(id, dto);
            
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult Delete([FromRoute] int id) //Metoda do usuwania restauracji.
        {
            _restaurantService.Delete(id);
            
           
                return NoContent();
            
        }
        [HttpPost]
        public ActionResult CreateRestaurant([FromBody] CreateRestaurantDto dto) // Metoda do dodawania restauracji.
        {
            
            var id =_restaurantService.Create(dto);
            return Created($"/api/restaurant/{id}", null);
        }
        [HttpGet]
        public ActionResult<IEnumerable<RestaurantDto>> GetAll() //Metoda do wypisania wszystkich restaracji
        {
            var restaurantsDtos = _restaurantService.GetAll();
            return Ok(restaurantsDtos);
        }
        [HttpGet("{id}")]
        public ActionResult<RestaurantDto> Get([FromRoute] int id) //Metoda do wyspiania danych restaurtacji po id ich.
        {
            var restaurant = _restaurantService.GetById(id);
            
            return Ok(restaurant);
        }
    }
}
