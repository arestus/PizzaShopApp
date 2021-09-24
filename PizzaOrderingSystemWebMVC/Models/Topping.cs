using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Models
{
    public partial class Topping
    {
        public Topping()
        {
            OrderItemDetails = new HashSet<OrderItemDetail>();
        }
        [Key]
        public int ToppingNumber { get; set; }
        public string ToppingName { get; set; }
        public int? ToppingPrice { get; set; }

        public virtual ICollection<OrderItemDetail> OrderItemDetails { get; set; }
    }
}
