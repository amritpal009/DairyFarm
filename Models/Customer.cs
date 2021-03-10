using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DairyFarm.Models
{
    public class Customer
    {

        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
