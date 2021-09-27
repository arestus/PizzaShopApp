using PizzaOrderingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPIzzaOrderingApplication.Services
{
    public class PizzaDetailsRepo : IRepo<PizzaDetail>
    {
        private readonly pizzaContext _context;

        public PizzaDetailsRepo(pizzaContext context)
        {
            _context = context;
        }
        public ICollection<PizzaDetail> GetOrderDetails()
        {
            throw new NotImplementedException();
        }

        public ICollection<PizzaDetail> GetOrderItemDetails(int Id)
        {
            IList<PizzaDetail> pizza = _context.PizzaDetails.Where(e => e.PizzaNumber == Id).ToList();
            return pizza;
        }
    }
}
