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
        public UserLoginDetail Add(UserLoginDetail k)
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

        public UserLoginDetail Delete(int id)
        {
            return null;
        }

        public UserLoginDetail Get(int id)
        {
            UserLoginDetail employee = null;
            try
            {
                employee = _context.UserLoginDetails.FirstOrDefault(e => e.UserId == id);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return employee;
        }

        public ICollection<PizzaDetail> GetAll()
        {

            return null;
        }

        public UserLoginDetail Update(UserLoginDetail k)
        {
            return null;
        }

        ICollection<UserLoginDetail> IRepo<UserLoginDetail>.GetAll()
        {
            return null;
        }
    }
}
