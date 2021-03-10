using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DairyFarm.Models;

namespace DairyFarm.Data
{
    public class DairyFarmContext : DbContext
    {
        public DairyFarmContext (DbContextOptions<DairyFarmContext> options)
            : base(options)
        {
        }

        public DbSet<DairyFarm.Models.Customer> Customer { get; set; }

        public DbSet<DairyFarm.Models.Order> Order { get; set; }

        public DbSet<DairyFarm.Models.Product> Product { get; set; }
    }
}
