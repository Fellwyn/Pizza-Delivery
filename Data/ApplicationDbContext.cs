using Delivery.Models;
using Microsoft.EntityFrameworkCore;




namespace Delivery.Data


{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {
            
        }
    }
}
