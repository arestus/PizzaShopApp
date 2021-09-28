using Microsoft.AspNetCore.Mvc;
using PizzaOrderingSystemWebMVC.Models;
using PizzaOrderingSystemWebMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepo<UserLoginDetail> _repo;
        private readonly pizzaContext _context;

        public UserController(IRepo<UserLoginDetail> repo, pizzaContext context)
        {
            _repo = repo;
            _context = context;
        }
        public IActionResult UserRegistration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserRegistration(UserLoginDetail userLoginDetail)
        {
            _repo.Add(userLoginDetail);
            //return View();
           return RedirectToAction("Index","Home");
        }
        public IActionResult UserLogin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UserLogin(UserLoginDetail user)
        {
           
            if (_context.UserLoginDetails.Where(e => e.UserMail == user.UserMail && e.UserPassword == user.UserPassword).Any())
            {
                TempData["loginname"] = user.UserMail;

                // return RedirectToAction("Index", "Home");
                return RedirectToAction("Index", "Pizza");
                //  return RedirectToAction("Orders", "Order");
            }
            else
            {

            }
            return View();
        }
        //public IActionResult Orders()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult Orders(PizzaDetail pizz)
        //{
        //    string name ="sdfName";
        //    TempData["PizzaName"] = name;
        //     return RedirectToAction(" Orders", "Order");
        //    // return View();
        //}
    }
}
