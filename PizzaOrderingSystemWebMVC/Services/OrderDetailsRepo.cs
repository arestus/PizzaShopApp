using Microsoft.EntityFrameworkCore;
using PizzaOrderingSystemWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Services
{
    public class OrderDetailsRepo : IRepo<OrderDetail>
    {
        private readonly pizzaContext _context;
        public OrderDetailsRepo(pizzaContext context)
        {
            _context = context;
        }

        public OrderDetail Add(OrderDetail k)
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

        public OrderDetail Delete(int id)
        {
            throw new NotImplementedException();
        }

        public OrderDetail Get(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<OrderDetail> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderDetail Update(OrderDetail k)
        {
            throw new NotImplementedException();
        }
    }
}
