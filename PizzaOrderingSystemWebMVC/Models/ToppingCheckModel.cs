using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Models
{
    public class ToppingCheckModel
    {
        public int ToppingNumber { get; set; }
        public string ToppingName { get; set; }
        public int? ToppingPrice { get; set; }

        public bool IsChecked { get; set; }
    }
    public class ToppingList
    {
        //use CheckBoxModel class as list 
        public List<ToppingCheckModel> Toppingss { get; set; }
    }
}
