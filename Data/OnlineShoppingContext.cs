using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class OnlineShoppingContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Courier> Couriers { get; set; }
        public DbSet<OrderShippingDetails> OrderShippingDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderShippingDetails>()
                .HasKey(o => new { o.CourierId, o.OrderId });

            modelBuilder.Entity<Product>().HasData(
              new Product()
              {
                  Id =1,
                  Name="Product 1",
                  Quntity=2
              },
               new Product()
               {
                   Id = 2,
                   Name = "Product 2",
                   Quntity = 0
               },
                new Product()
                {
                    Id = 3,
                    Name = "Product 3",
                    Quntity = 1
                });

            modelBuilder.Entity<Courier>().HasData(
             new Courier()
             {
                 Id = 1,
                 Name = "Ahmed",
                 IsAvaliable = true
             },
              new Courier()
              {
                  Id =2,
                  Name = "Youssef",
                  IsAvaliable = true
              }
             );

            base.OnModelCreating(modelBuilder);
        }
    }
}
