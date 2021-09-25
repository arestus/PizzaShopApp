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
            modelBuilder.Entity<UserLoginDetail>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__B0FBA213F7B4106B");

                entity.Property(e => e.UserMail)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("user_email");

                entity.Property(e => e.UserPhone)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Phone_No");

                entity.Property(e => e.UserAddress)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("User_Address");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("User_name");

                entity.Property(e => e.UserPassword)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("User_password");
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
