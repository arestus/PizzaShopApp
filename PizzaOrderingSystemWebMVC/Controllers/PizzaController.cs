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
        private readonly IRepo<OrderDetail> _repoOrder;

        public PizzaController(IRepo<PizzaDetail> repo, IRepo<Topping> repoToping, IRepo<OrderItemDetail> repoOrdItem, IRepo<OrderDetail> repoOrder)
        {
            _repo = repo;
            _repoToping = repoToping;
            _repoOrdItem = repoOrdItem;
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
    }
}
