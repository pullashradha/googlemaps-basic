using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GoogleMaps_Basic.Models;
using Google;

namespace GoogleMaps_Basic.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMap(int latitude, int longitude)
        {
            var mapCanvas = document.getElementById("map");
            var mapOptions =
            {
                center: new google.maps.LatLng(latitude, longitude),
                zoom: 16
            }

            var newMap = new google.maps.Map(mapCanvas, mapOptions);
            return View(newMap);
        }
    }
}
