using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemWebMVC.Services;
using PizzaOrderingSystemWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Controllers
{
    public class OrderDetailController : Controller
    {
        readonly IRepo<OrderDetail> _repo;
        private readonly IRepo<PizzaDetail> _pizza;
        private readonly IRepo<OrderItemDetail> _item;
        private readonly IRepo<Topping> _topping;
        private readonly pizzaContext _context;
        private readonly IRepo<Order> _repoOrder;

        public OrderDetailController(IRepo<OrderDetail> repo, IRepo<PizzaDetail> pizza, IRepo<OrderItemDetail> item, IRepo<Topping> topping, pizzaContext context, IRepo<Order> repoOrder)
        {
            _repo = repo;
            _pizza = pizza;
            _item = item;
            _topping = topping;
            _context = context;
            _repoOrder = repoOrder;
        }

        public IActionResult Index()
        {
            ViewBag.ItemDetails = _repo.GetOrderItemDetails(Convert.ToInt32(TempData.Peek("orderId")));
                                // IList<PizzaDetail> pizzas = null;
            IList<OrderItemDetail> items = null;
            IList<Topping> toppings = null;

            List<FinalOutputModel> obj = new();
           

            foreach (var item in ViewBag.ItemDetails)
            {
                FinalOutputModel output = new();
                output.Pizza = _pizza.Get(item.PizzaNumber);
                output.Toppings = new();
                int pizzanumber = item.PizzaNumber;
                            // int itemnumber = item.ItemNumber;
                //ViewBag.PizzaDetails = _pizza.GetOrderItemDetails(pizzanumber);
                            // pizzas = (IList<PizzaDetail>)_pizza.GetOrderItemDetails(pizzanumber);
                //ViewBag.PizzaDetails = pizzas;
                items = (IList<OrderItemDetail>)_item.GetOrderItemDetails(item.ItemNumber);
                foreach (var itemtopping in items)
                {
                    
                   Topping topping = _topping.Get(itemtopping.ToppingNumber);
                    output.Toppings.Add(topping);
                    int orderId = Convert.ToInt32(TempData.Peek("orderId"));
                    Order order = _repoOrder.Get(orderId);
                    if (order.TotalAmount < 50)
                    {
                        order.TotalAmount += 5;
                        ViewBag.deliveryPrice = 5;
                    }
                    else
                    {
                        ViewBag.deliveryPrice = 0;
                    }
                    ViewBag.theOrder = order;
                               
                }
                obj.Add(output);
            }
            // ViewBag.PizzaDetails = pizzas;
            OutputList objBind = new();
            objBind.FinalListPizzas = obj;
            return View(objBind);
        }
        public IActionResult Confirm()
        {
            return View();
        }
    }
}

