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
        private readonly IRepo<PizzaDetail> _repo;
        private readonly IRepo<Order> _repos;
        private readonly pizzaContext _context;
        private readonly IRepo<Topping> _tops;
        private readonly IRepo<OrderItemDetail> _repoOrdItem;
        private readonly IRepo<OrderDetail> _repoOrderDetail;
        // private readonly UserLoginDetail _cont;


        public OrderController(IRepo<PizzaDetail> repo, IRepo<Order> repos, pizzaContext context, IRepo<Topping> tops)
        {
            _repo = repo;
            _repos = repos;
            _context = context;
            _tops = tops;

        }

        //public IActionResult Orders(int id)
        //{
        //    //if (_context.UserLoginDetails.Where(e => e.UserMail == user.UserMail).Any())
        //    //{
        //    return (_context.Get(id));

        //}
        public IActionResult Index()
        {
            List<viewBillingModel> bills = new();
            int orderId = Convert.ToInt32(TempData.Peek("orderId"));
           
            return View();
        }
        public IActionResult PizzaList(PizzaDetail pizz)
        {

            return View(_repo.GetAll());
            // return View(_repo.Get(id));

        }

        public IActionResult Orders()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Orders(PizzaDetail pizz)
        {
            ViewBag.Name = TempData["username"];
            return RedirectToAction("PizzaList");
        }
        public IActionResult Billing(int id)
        {

            //return RedirectToAction("Index", "Sumarry");
            return View(_repo.Get(id));
            // return View();

            // return RedirectToAction("Index", "Sumarry");



        }
        [HttpPost]
        public IActionResult Billing(int id, UserLoginDetail user, PizzaDetail pizz)
        {
            //return View(_repo.Get(id));
            // return RedirectToAction("Index", "Sumarry");
            // return RedirectToAction("bill");

            // return RedirectToAction("Index", "Sumarry");


            return View();
        }

        public IActionResult bill(int id, PizzaDetail pizz)
        {
            ViewBag.pizza = pizz.PizzaName;
            //  ViewBag.Name = pizz.PizzaName;


            return RedirectToAction("Index", "Sumarry", pizz);
            //TempData["pizzaprice"] = pizz.PizzaPrice;

            //return RedirectToAction("Index", "Sumarry");
            // return View(_tops.GetAll());
            //  PizzaDetail pizz = new PizzaDetail();


            //_repos.Add(or);

            //    return View();


        }




    }
}

