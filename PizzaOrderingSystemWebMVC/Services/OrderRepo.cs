using Microsoft.EntityFrameworkCore;
using PizzaOrderingSystemWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Services
{
    public class OrderRepo : IRepo<Order>
    {
        private pizzaContext _context;

        public OrderRepo(pizzaContext context)
        {
            _context = context;
        }
        public Order Add(Order k)
        {
            try
            {
                _context.Orders.Add(k);
                _context.SaveChanges();
                return k;
            }
            catch (DbUpdateConcurrencyException ducex)
            {

                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException duex)
            {

                Console.WriteLine(duex.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }

        public Order Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public Order Update(Order k)
        {
            throw new NotImplementedException();
        }
    }
}
