using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemWebMVC.Services;
using PizzaOrderingSystemWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPIzzaOrderingApplication.Controllers
{
    public class OrderDetailController : Controller
    {
        readonly IRepo<OrderDetail> _repo;
        private readonly IRepo<PizzaDetail> _pizza;
        private readonly IRepo<OrderItemDetail> _item;
        private readonly IRepo<Topping> _topping;
        private readonly pizzaContext _context;

        public OrderDetailController(IRepo<OrderDetail> repo, IRepo<PizzaDetail> pizza, IRepo<OrderItemDetail> item, IRepo<Topping> topping, pizzaContext context)
        {
            _repo = repo;
            _pizza = pizza;
            _item = item;
            _topping = topping;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.ItemDetails = _repo.GetOrderItemDetails(1);
            IList<PizzaDetail> pizzas = null;
            IList<OrderItemDetail> items = null;
            IList<Topping> toppings = null;
            foreach (var item in ViewBag.ItemDetails)
            {
                int pizzanumber = item.PizzaNumber;
                int itemnumber = item.ItemNumber;
                //ViewBag.PizzaDetails = _pizza.GetOrderItemDetails(pizzanumber);
                pizzas = (IList<PizzaDetail>)_pizza.GetOrderItemDetails(pizzanumber);
                //ViewBag.PizzaDetails = pizzas;
                items = (IList<OrderItemDetail>)_item.GetOrderItemDetails(itemnumber);
                foreach (var itemtopping in items)
                {
                    int toppingnumber = itemtopping.ToppingNumber;
                    toppings = (IList<Topping>)_topping.GetOrderItemDetails(toppingnumber);
                    ViewBag.ToppingDetails = toppings;
                }
            }
            ViewBag.PizzaDetails = pizzas;
            return View(_repo.GetOrderItemDetails(1));
        }
        public IActionResult Confirm()
        {
            return View();
        }
    }
}

