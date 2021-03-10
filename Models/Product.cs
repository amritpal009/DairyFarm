using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DairyFarm.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
         public int Price { get; set; }
        public string Type { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
