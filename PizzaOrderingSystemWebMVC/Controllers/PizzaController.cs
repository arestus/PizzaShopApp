using Microsoft.AspNetCore.Http;
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
        private readonly pizzaContext _context;
        IFormCollection frm;

        public PizzaController(IRepo<PizzaDetail> repo, IRepo<Topping> repoToping, IRepo<OrderItemDetail> repoOrdItem, IRepo<OrderDetail> repoOrderDetail, IRepo<Order> repoOrder, pizzaContext context)
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

            //return RedirectToAction("Index", "Topping");
        }
        [HttpPost]
        public IActionResult Index(int id)
        {
            ViewBag.Message = _repo.Get(id);

            return RedirectToAction("Details");
        }

        public IActionResult Details(int id)
        {


            ViewBag.thePizza = _repo.Get(id);
           

            //return RedirectToAction("Index", "Topping");
            return View(_repoToping.GetAll());
        }
        [HttpPost]
        public IActionResult Details(IFormCollection frm)
        {
          //  UserLoginDetail user;
            Order newOrder;
            int TotalAmount = 0;
            ViewBag.loginname = TempData.Peek("loginname");
            foreach (var item in _context.UserLoginDetails)
            {
                if (ViewBag.loginname == item.UserMail)
                {
                    TempData["userid"] = item.UserId;
                }
            }
            ViewBag.id = TempData.Peek("userid");
            int price = Convert.ToInt32(TempData.Peek("pizzaPrice"));
            
            

            if (TempData.Peek("orderId") == null)
            {
                newOrder = new() { UserId = ViewBag.id /*@TempData.Peek("UserId")*/, TotalAmount = 0, DelivaryCharges = 0};

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
            // TempData["ids"] = ViewBag.ids;
            // int View = Convert.ToInt32(TempData.Peek("id"));



            // ViewBag.number =  TempData.Peek("id");

            //ViewBag.Name = 1;

            //string  item_number = frm["Olive"].ToString();
            int number;
            string item_number;
            try
            {
                item_number = frm["Olive"].ToString();
                number = Convert.ToInt32(item_number);
            }
            catch (Exception)
            {

                item_number = frm["Olive"].ToString();
                number = Convert.ToInt32(item_number);
            }
            

            OrderItemDetail itemOrder = new() { ItemNumber = orderDetail.ItemNumber, ToppingNumber = number};
            price += (int)_repoToping.Get(number).ToppingPrice;
            _repoOrdItem.Add(itemOrder);


            //OrderItemDetail itemOrder = new() { ItemNumber = orderDetail.ItemNumber, ToppingNumber = ViewBag.number };
            ////// price += (int)_repoToping.Get(pri).ToppingPrice;
            //_repoOrdItem.Add(itemOrder);

            //{
            //    OrderItemDetail itemOrder = new() { ItemNumber = orderDetail.ItemNumber, ToppingNumber = item };
            //    price += (int)_repoToping.Get(item).ToppingPrice;
            //    _repoOrdItem.Add(itemOrder);
            //}
            newOrder.TotalAmount += price;
            //TempData["TotalAmount"] = newOrder.TotalAmount;
            if (TotalAmount > 50)
            {
                newOrder.DelivaryCharges = 5;
                newOrder.Status = "confirmed";
            }
            else
            {
                newOrder.DelivaryCharges = 2;
                newOrder.Status = "confirmed";
            }
            
            _repoOrder.Update(newOrder);
            //  ViewBag.BirdSighting = TempData.Peek("pizzaChoise");
            // return RedirectToAction("Index");
            // TempData["TotalAmount"] = newOrder.TotalAmount;
           
            return RedirectToAction("Index");
        }
     
        public  int  CheckRadio(IFormCollection frm)
        {
            
            int number;
            string item_number;
            try
            {
                item_number = frm["Olive"].ToString();
                 number = Convert.ToInt32(item_number);
            }
            catch (Exception)
            {

                item_number = frm["Olive"].ToString();
                 number = Convert.ToInt32(item_number);
            }
         
            
           
            return number;
        }
        }
}
