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
            Order order = null;
            try
            {
                order = _context.Orders.FirstOrDefault(e => e.OrderId == id);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return order;
        }

        public ICollection<Order> GetAll()
        {
            throw new NotImplementedException();
        }

        public ICollection<Order> GetOrderItemDetails(int Id)
        {
            throw new NotImplementedException();
        }

        public Order Update(Order k)
        {
            Order order = null;
            try
            {
                order = _context.Orders.FirstOrDefault(e => e.OrderId == k.OrderId);
                order.UserId = k.UserId;
                order.TotalAmount = k.TotalAmount;
                order.DelivaryCharges = k.DelivaryCharges;
                order.Status = k.Status;
                _context.SaveChanges();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (DbUpdateConcurrencyException ducex)
            {
                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException dbuex)
            {
                Console.WriteLine(dbuex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return order;
        }
    }
}

