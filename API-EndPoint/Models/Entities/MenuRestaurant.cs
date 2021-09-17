using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_EndPoint.Models.Entities
{
    public class MenuRestaurant
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public int Quantity { get; set; }
        public float price { get; set; }
    }
}
