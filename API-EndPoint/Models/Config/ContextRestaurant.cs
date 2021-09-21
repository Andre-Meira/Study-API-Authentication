using API_EndPoint.Models.Entities;
using Microsoft.EntityFrameworkCore;


namespace API_EndPoint.Models.Config_Migration
{
    public class ContextRestaurant : DbContext
    {
        public ContextRestaurant(DbContextOptions<ContextRestaurant> options): 
            base(options)
        {}

        public DbSet<MenuRestaurant> MenuRestaurants { get; set; }

    }
}
