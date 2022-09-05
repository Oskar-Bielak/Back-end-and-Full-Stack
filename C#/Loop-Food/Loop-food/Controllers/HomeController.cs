using Loop_food.Models;
using Loop_food.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Loop_food.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly IWarehorseService _warehorseService;
        public HomeController(IWarehorseService warehorseService)
        {
            _warehorseService = warehorseService;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("polityka-prywatnosci")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("zaloguj-sie")]
        public IActionResult Login()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Newsletter()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Newsletter(NewsletterModel body)
        {
            if(!ModelState.IsValid)
            {
                return View(body);
            }
            var id = _warehorseService.Save(body);
            ViewData["NewsletterID"] = id;
            TempData["NewsletterID"] = id;
            return RedirectToAction("Newsletter");
        }

        
    }
}
