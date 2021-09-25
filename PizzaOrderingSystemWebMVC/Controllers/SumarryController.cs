using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Controllers
{
    public class SumarryController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = TempData.Peek("pizzaname"); 
            ViewBag.Price = TempData.Peek("pizzaprice");
            ViewBag.Type = TempData.Peek("pizzatype");

            return View();
        }
    }
}
