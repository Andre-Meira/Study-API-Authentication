using API_EndPoint.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
