using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Models
{
    public class viewBillingModel
    {
        public string PizzaName { get; set; }

        public string[] TopingName { get; set; }
        public int TotalPrise { get; set; }
       
    }
}
