using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfServicePizzaCodeFirst.Model;

namespace WcfServicePizzaCodeFirst.Persistence
{
    public class PizzaDbContext : DbContext
    {
        public PizzaDbContext() : base("PizzaDB") { }

        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}