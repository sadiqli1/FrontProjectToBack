using System.Collections.Generic;
using FrontProjectToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrontProjectToBack.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Slider> sliders = new List<Slider>()
            {
                new Slider
                {
                    Id = 1,
                    Image = "https://htmldemo.net/juan/juan/assets/img/slider/slider-1.jpg",
                    Info = "Top Selling!",
                    Title = "New Collection",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                    Button = "SHOP NOW"
                },
                new Slider
                {
                    Id = 2,
                    Image = "https://htmldemo.net/juan/juan/assets/img/slider/slider-2.jpg",
                    Info = "Best Selling!",
                    Title = "New Collection",
                    Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incidid",
                    Button = "SHOP NOW"
                }
            };
            ViewBag.Slider = sliders;
            return View(sliders);
        }
    }
}
