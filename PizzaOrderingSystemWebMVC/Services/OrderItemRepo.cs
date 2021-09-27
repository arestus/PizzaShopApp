using Microsoft.EntityFrameworkCore;
using PizzaOrderingSystemWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Services
{
    public class OrderItemRepo : IRepo<OrderItemDetail>
    {
        private readonly pizzaContext _context;
        public OrderItemRepo(pizzaContext context)
        {
            _context = context;
        }
        public OrderItemDetail Add(OrderItemDetail k)
        {
            try
            {
                _context.Add(k);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ducex)
            {
                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException dbuex)
            {
                Console.WriteLine(dbuex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;

        }

        public OrderItemDetail Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrderItemDetail Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<OrderItemDetail> GetAll()
        {
            IList<OrderItemDetail> orderItem = _context.OrderItemDetails.ToList();
            if (orderItem.Count > 0)
                return orderItem;
            else
                return null;
        }

        public OrderItemDetail Update(OrderItemDetail k)
        {
            throw new NotImplementedException();
        }
    }
}
