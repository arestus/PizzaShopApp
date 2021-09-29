using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemWebMVC.Models;
using PizzaOrderingSystemWebMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Controllers
{
    public class ToppingController : Controller
    {
        private readonly IRepo<Topping> _repo;
        private readonly IRepo<OrderItemDetail> _repoOrdItem;

        public ToppingController(IRepo<Topping> repo, IRepo<OrderItemDetail> repoOrdItem)
        {
            _repo = repo;
            _repoOrdItem = repoOrdItem;

        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }

    
        //public IActionResult Index(int id)
        //{
        //    ViewBag.Message = _repo.Get(id);

        //    return RedirectToAction("Index");
        //}
        public IActionResult Details(int id)
        {
            //ViewBag.thetop = _repo.Get(id);

            //return RedirectToAction("Index", "Topping");
           // return View(_repo.GetAll());
           return View(_repo.Get(id));

        }
        [HttpPost]
        public IActionResult Details(Topping top)
        {
            TempData["TopNumber"] = top.ToppingNumber;

            return RedirectToAction("OrderDetails");


           
        }
         public IActionResult OrderDetails( )
        {
            ViewBag.name = TempData.Peek("TopNumber");
            ViewBag.TotalAmount = TempData.Peek("TotalAmount");
            //int price = 0;

            //OrderDetail orderDetail = new()
            //{
            //    OrderId = Convert.ToInt32(TempData.Peek("orderId")),
            //    PizzaNumber = Convert.ToInt32(TempData.Peek("pizzaChoise"))
            //};
            //ViewBag.Num = TempData.Peek("TopNumber");
            //OrderItemDetail itemOrder = new() { ItemNumber = orderDetail.ItemNumber, ToppingNumber = ViewBag.Num };
            //price += (int)_repo.Get(ViewBag.Num).ToppingPrice;
            //_repoOrdItem.Add(itemOrder);
            //  return RedirectToAction("Details","Pizza");
            return View();


        }


        //[HttpPost]
        //public IActionResult OrderDetails(int id)
        //{
        //    ViewBag.name = TempData.Peek("TopNumber");
        //    //int price = 0;

        //    //OrderDetail orderDetail = new()
        //    //{
        //    //    OrderId = Convert.ToInt32(TempData.Peek("orderId")),
        //    //    PizzaNumber = Convert.ToInt32(TempData.Peek("pizzaChoise"))
        //    //};
        //    //ViewBag.Num = TempData.Peek("TopNumber");
        //    //OrderItemDetail itemOrder = new() { ItemNumber = orderDetail.ItemNumber, ToppingNumber = ViewBag.Num };
        //    //price += (int)_repo.Get(ViewBag.Num).ToppingPrice;
        //    //_repoOrdItem.Add(itemOrder);
        //    //  return RedirectToAction("Details","Pizza");
        //    return View();

        //}

    }
}
