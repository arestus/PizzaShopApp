using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PizzaOrderingSystemWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly pizzaContext _context;
        public HomeController(ILogger<HomeController> logger, pizzaContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.UserName = TempData["username"];
            foreach (var item in _context.PizzaDetails )
            {
                ViewBag.Name = item.PizzaName;
                ViewBag.Price = item.PizzaPrice;
                ViewBag.Type = item.PizzaType;

            }
            foreach (var items in _context.Toppings)
            {
                ViewBag.Topping = items.ToppingName;
                ViewBag.Price = items.ToppingPrice;
              

            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
