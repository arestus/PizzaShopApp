using PizzaOrderingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCPIzzaOrderingApplication.Services
{
    public class OrderItemDetailsRepo : IRepo<OrderItemDetail>
    {
        private readonly pizzaContext _context;

        public OrderItemDetailsRepo(pizzaContext context)
        {
            _context = context;
        }
        public ICollection<OrderItemDetail> GetOrderDetails()
        {
            throw new NotImplementedException();
        }

        public ICollection<OrderItemDetail> GetOrderItemDetails(int Id)
        {
            IList<OrderItemDetail> itemDetails = _context.OrderItemDetails.Where(e => e.ItemNumber == Id).ToList();
            return itemDetails;
        }
        
    }
}
