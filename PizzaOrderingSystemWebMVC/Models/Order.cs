using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public int? UserId { get; set; }
        public double? TotalAmount { get; set; }
        public int? DelivaryCharges { get; set; }
        public string Status { get; set; }

        public virtual UserLoginDetail User { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
