using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Controllers
{
    public class ToppingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
