using PizzaOrderingSystemWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Services
{
    public class SummaryRepo : IRepo<PizzaDetail>
    {
        private readonly pizzaContext _context;
        public SummaryRepo(pizzaContext context)
        {
            _context = context;
        }
        public PizzaDetail Add(PizzaDetail k)
        {
            return null;  
        }

        public PizzaDetail Delete(int id)
        {
            return null;
        }

        public PizzaDetail Get(int id)
        {
            PizzaDetail pizz = null;
            try
            {
                pizz = _context.PizzaDetails.FirstOrDefault(e => e.PizzaNumber == id);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return pizz;
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
            return null;
        }
    }
}
