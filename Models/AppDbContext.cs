using Microsoft.EntityFrameworkCore;

namespace _24h_Code_Challenge.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {           
        }

        public DbSet<Orders> Orders { get; set; }

        public DbSet<OrderDetails> OrderDetails { get; set; }

        public DbSet<Pizzas> Pizzas { get; set; }

        public DbSet<PizzaTypes> PizzaTypes { get; set; }

    }
}
