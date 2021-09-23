using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Models
{
    public partial class UserLoginDetail
    {
        public UserLoginDetail()
        {
            Orders = new HashSet<Order>();
        }
        [Key]
        public int UserId { get; set; }
        
        public string UserMail { get; set; }
        
        public string UserName { get; set; }
       
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }
      
        public string UserAddress { get; set; }
       
        public string UserPhone { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
