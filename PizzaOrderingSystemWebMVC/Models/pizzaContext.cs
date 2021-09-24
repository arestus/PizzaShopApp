using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC.Models
{
    public partial class pizzaContext : DbContext
    {
        public pizzaContext()
        {
        }

        public pizzaContext(DbContextOptions<pizzaContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItemDetail>(entity =>
            {
                entity.HasKey(e => new { e.ItemNumber, e.ToppingNumber });
            });
        }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderItemDetail> OrderItemDetails { get; set; }
        public virtual DbSet<PizzaDetail> PizzaDetails { get; set; }
        public virtual DbSet<Topping> Toppings { get; set; }
        public virtual DbSet<UserLoginDetail> UserLoginDetails { get; set; }
    }
}
