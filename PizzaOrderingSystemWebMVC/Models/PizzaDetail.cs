using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Models
{
    public partial class PizzaDetail
    {
        public PizzaDetail()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        [Key]
        public int PizzaNumber { get; set; }
        public string PizzaName { get; set; }
        public int? PizzaPrice { get; set; }
        public string PizzaType { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
