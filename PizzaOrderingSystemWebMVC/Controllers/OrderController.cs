using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemWebMVC.Models;
using PizzaOrderingSystemWebMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Controllers
{

    public class OrderController : Controller
    {
        private readonly pizzaContext _context;
       
        public OrderController(pizzaContext context)
        {
            _context = context;
        }
      
      
        public IActionResult Orders()
        {
            foreach (var item in _context.PizzaDetails)
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
    }
}
