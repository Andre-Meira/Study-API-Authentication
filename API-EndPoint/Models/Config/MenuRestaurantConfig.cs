using API_EndPoint.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_EndPoint.Models.Config_Migration
{
    public class MenuRestaurantConfig : IEntityTypeConfiguration<MenuRestaurant>
    {
        public void Configure(EntityTypeBuilder<MenuRestaurant> builder)
        {
            builder.HasKey(key => key.Id);
        }
    }
}
