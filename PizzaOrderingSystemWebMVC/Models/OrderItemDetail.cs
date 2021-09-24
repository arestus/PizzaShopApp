using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Models
{
    public partial class OrderItemDetail
    {
        
        public int ItemNumber { get; set; }
        public int ToppingNumber { get; set; }

        public virtual OrderDetail ItemNumberNavigation { get; set; }
        public virtual Topping ToppingNumberNavigation { get; set; }
    }
}
