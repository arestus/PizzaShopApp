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

        public Topping Get(int id)
        {
            Topping top = null;
            try
            {
                top = _context.Toppings.FirstOrDefault(e => e.ToppingNumber == id);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return top;
        }

        public ICollection<Topping> GetAll()
        {
            IList<Topping> tops = _context.Toppings.ToList();
            if (tops.Count > 0)
                return tops;
            else
                return null;
        }

        public Topping Update(Topping k)
        {
            throw new NotImplementedException();
        }
    }
}
