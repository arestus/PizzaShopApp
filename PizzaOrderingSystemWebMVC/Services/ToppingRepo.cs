using PizzaOrderingSystemWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Services
{
    public class ToppingRepo : IRepo<Topping>
    {
        private readonly pizzaContext _context;
        public ToppingRepo(pizzaContext context)
        {
            _context = context;
        }
        public Topping Add(Topping k)
        {
            throw new NotImplementedException();
        }

        public Topping Delete(int id)
        {
            throw new NotImplementedException();
        }

       
     
        public ICollection<Topping> GetAll()
        {
          
            IList<Topping> toppings = _context.Toppings.ToList();
            if (toppings.Count > 0)
                return toppings;
            else
                return null;
        }

        public Topping Update(Topping k)
        {
            throw new NotImplementedException();
        }

        Topping IRepo<Topping>.Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
