using PizzaOrderingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPIzzaOrderingApplication.Services
{
    public class ToppingsRepo : IRepo<Topping>
    {
        private readonly pizzaContext _context;

        public ToppingsRepo(pizzaContext context)
        {
            _context = context;
        }
        public ICollection<Topping> GetOrderDetails()
        {
            throw new NotImplementedException();
        }

        public ICollection<Topping> GetOrderItemDetails(int Id)
        {

            IList<Topping> toppingDetails = _context.Toppings.Where(e => e.ToppingNumber == Id).ToList();
            return toppingDetails;
        }
    }
}
