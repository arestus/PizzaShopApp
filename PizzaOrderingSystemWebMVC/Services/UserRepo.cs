using Microsoft.EntityFrameworkCore;
using PizzaOrderingSystemWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Services
{
    public class UserRepo : IRepo<UserLoginDetail>
    {
        private readonly pizzaContext _context;

        public UserRepo(pizzaContext context)
        {
            _context = context;
        }
        public UserLoginDetail Add (UserLoginDetail k)
        {
            try
            {
                _context.UserLoginDetails.Add(k);
                _context.SaveChanges();
                return k;
            }
            catch (DbUpdateConcurrencyException ducex)
            {

                Console.WriteLine(ducex.Message);
            }
            catch (DbUpdateException duex)
            {

                Console.WriteLine(duex.Message);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return null;
        }

        public ICollection<PizzaDetail> GetAll()
        {
            IList<PizzaDetail> employees = _context.PizzaDetails.ToList();
            if (employees.Count > 0)
                return employees;
            else
                return null;
        }

        ICollection<UserLoginDetail> IRepo<UserLoginDetail>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
