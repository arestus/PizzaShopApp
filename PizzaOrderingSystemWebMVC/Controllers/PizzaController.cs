using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemWebMVC.Models;

using PizzaOrderingSystemWebMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private readonly pizzaContext _context;

        public PizzaController(pizzaContext context, IRepo<PizzaDetail> repo, IRepo<Topping> repoToping,
            IRepo<OrderItemDetail> repoOrdItem, IRepo<OrderDetail> repoOrderDetail, IRepo<Order> repoOrder)
        {
            _repo = repo;
            _repoToping = repoToping;
            _repoOrdItem = repoOrdItem;
            _repoOrderDetail = repoOrderDetail;
            _repoOrder = repoOrder;
            _context = context;
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
            List<ToppingCheckModel> obj = new();
            List<Topping> ttp = _repoToping.GetAll().ToList();
            foreach (var item in ttp)
            {
                ToppingCheckModel t = new() { ToppingNumber = item.ToppingNumber, ToppingName = item.ToppingName, ToppingPrice = item.ToppingPrice, IsChecked = false };
                obj.Add(t);
            }

            ToppingList objBind = new ToppingList();
            
            objBind.Toppingss = obj;
            ViewBag.thePizza = _repo.Get(id);
            return View(objBind);
        }
        [HttpPost]
        public IActionResult Details(ToppingList Obj)
        {

            Order newOrder;
            int price = Convert.ToInt32(TempData.Peek("pizzaPrice"));
            ViewBag.loginname = TempData.Peek("loginname");
            foreach (var item in _context.UserLoginDetails)
            {
                if (ViewBag.loginname == item.UserMail)
                {
                    TempData["userid"] = item.UserId;
                }
            }
            if (TempData.Peek("orderId") == null)
            {
                newOrder = new() { UserId = Convert.ToInt32(TempData.Peek("userid")), TotalAmount = 0, };

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


            foreach (var item in Obj.Toppingss)
            {

                if (item.IsChecked)
                {
                    OrderItemDetail itemOrder = new() { ItemNumber = orderDetail.ItemNumber, ToppingNumber = item.ToppingNumber };
                    price += (int)_repoToping.Get(item.ToppingNumber).ToppingPrice;
                    _repoOrdItem.Add(itemOrder);
                }
            }

            newOrder.TotalAmount += price;
            _repoOrder.Update(newOrder);
            return RedirectToAction("Index", "OrderDetail");
        }
    }
}
