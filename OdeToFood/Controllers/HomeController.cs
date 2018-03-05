using Microsoft.AspNetCore.Mvc;
using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Restaurant { Id = 1, Name = "Andrews Pizza Place" };
            return View(model);
        }
    }
}
