using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemWebMVC.Models;

using PizzaOrderingSystemWebMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Controllers
{
    public class PizzaController : Controller
    {
        private readonly IRepo<PizzaDetail> _repo;
        private readonly IRepo<Topping> _repoToping;
        private readonly IRepo<OrderItemDetail> _repoOrdItem;
        private readonly IRepo<OrderDetail> _repoOrderDetail;
        private readonly IRepo<Order> _repoOrder;

        public PizzaController(IRepo<PizzaDetail> repo, IRepo<Topping> repoToping, IRepo<OrderItemDetail> repoOrdItem, IRepo<OrderDetail> repoOrderDetail, IRepo<Order> repoOrder)
        {
            _repo = repo;
            _repoToping = repoToping;
            _repoOrdItem = repoOrdItem;
            _repoOrderDetail = repoOrderDetail;
            _repoOrder = repoOrder;
        }


        public IActionResult Index()
        {

            return View(_repo.GetAll());
        }
        [HttpPost]
        public IActionResult Index(int id)
        {
            ViewBag.Message = _repo.Get(id);

            return RedirectToAction("Index", "Topping");
        }

        public IActionResult Details(int id)
        {


            ViewBag.thePizza = _repo.Get(id);
            return View(_repoToping.GetAll());
        }
        [HttpPost]
        public IActionResult Details()
        {
            Order newOrder;
            int price = Convert.ToInt32(TempData.Peek("pizzaPrice"));
            if (TempData.Peek("orderId") == null)
            {
                newOrder = new() { UserId = 1 /*@TempData.Peek("UserId")*/, TotalAmount = 0, };

                _repoOrder.Add(newOrder);
                TempData["orderId"] = newOrder.OrderId;
            }
            else
            {
                newOrder = _repoOrder.Get(Convert.ToInt32(TempData.Peek("orderId")));
            }

            OrderDetail orderDetail = new()
            {
                OrderId = Convert.ToInt32(TempData.Peek("orderId")),
                PizzaNumber = Convert.ToInt32(TempData.Peek("pizzaChoise"))
            };
            _repoOrderDetail.Add(orderDetail);
            int[] arr = { 1, 2 };
            foreach (var item in arr)
            {
                OrderItemDetail itemOrder = new() { ItemNumber = orderDetail.ItemNumber, ToppingNumber = item };
                price += (int)_repoToping.Get(item).ToppingPrice;
                _repoOrdItem.Add(itemOrder);
            }
            newOrder.TotalAmount += price;
            _repoOrder.Update(newOrder);
            //  ViewBag.BirdSighting = TempData.Peek("pizzaChoise");
            return RedirectToAction("Index");
        }
    }
}
