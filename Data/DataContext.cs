using _24h_Code_Challenge.Entities;
using Microsoft.EntityFrameworkCore;

namespace _24h_Code_Challenge.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<OrderDetail> OrderDetails { get; set; }

        public virtual DbSet<Pizza> Pizzas { get; set; }

        public virtual DbSet<PizzaType> PizzaTypes { get; set; }
    }
}
