using PizzaOrderingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPIzzaOrderingApplication.Services
{
    public class OrderDetailRepo : IRepo<OrderDetail>
    {
        private readonly pizzaContext _context;

        public OrderDetailRepo(pizzaContext context)
        {
            _context = context; 
        }
        public ICollection<OrderDetail> GetOrderDetails()
        {
            IList<OrderDetail> orderDetails = _context.OrderDetails.ToList();
            
            if (orderDetails.Count > 0)
                return orderDetails;
            else
                return null;
        }

        public ICollection<OrderDetail> GetOrderItemDetails(int Id)
        {
            IList<OrderDetail> orderDetails = _context.OrderDetails.Where(e=>e.OrderId == Id).ToList();
            return orderDetails;
        }


        //public OrderDetail GetOrderItemDetails(int orderId)
        //{
        //    PizzaDetail pizza;
        //    var items = _context.OrderDetails.Where(e => e.OrderId == orderId).ToList();
        //    foreach (var item in items)
        //    {
        //        int pizzaNumber = (int)item.PizzaNumber;
        //        int itemNumber = (int)item.ItemNumber;
        //        pizza = _context.PizzaDetails.Find(pizzaNumber);

        //        var toppings = _context.OrderItemDetails.Where(e => e.ItemNumber == itemNumber).ToList();

        //        if (toppings.Count != 0)
        //        {
        //            foreach (var topping in toppings)
        //            {
        //                int toppingNumber = (int)topping.ToppingNumber;
        //                var topp = _context.Toppings.Find(toppingNumber);
        //            }
        //        }
        //    }
        //    return pizza;
        //}
    }
}
