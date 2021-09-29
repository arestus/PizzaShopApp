using PizzaOrderingSystemWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Services
{
    public class PizzaRepo : IRepo<PizzaDetail>
    {
        private readonly pizzaContext _context;
        public PizzaRepo(pizzaContext context)
        {
            _context = context;
        }
        public PizzaDetail Add(PizzaDetail k)
        {
            throw new NotImplementedException();
        }

        public PizzaDetail Delete(int id)
        {
            throw new NotImplementedException();
        }

        public PizzaDetail Get(int id)
        {
            PizzaDetail pizza = null;
            try
            {
                pizza = _context.PizzaDetails.FirstOrDefault(e => e.PizzaNumber == id);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return pizza;
        }

        public ICollection<PizzaDetail> GetAll()
        {
            IList<PizzaDetail> pizzas = _context.PizzaDetails.ToList();
            if (pizzas.Count > 0)
                return pizzas;
            else
                return null;
        }

        public PizzaDetail Update(PizzaDetail k)
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
