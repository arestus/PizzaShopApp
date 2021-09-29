using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Models
{
    public class FinalOutputModel
    {
        public PizzaDetail Pizza { get; set; }
        public List<Topping> Toppings { get; set; }
    }
    public class OutputList
    {
       public List<FinalOutputModel> FinalListPizzas { get; set; }
    }
}
