using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DairyFarm.Data;
using DairyFarm.Models;

namespace DairyFarm.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly DairyFarm.Data.DairyFarmContext _context;

        public IndexModel(DairyFarm.Data.DairyFarmContext context)
        {
            _context = context;
        }

        public IList<Customer> Customer { get;set; }

        public async Task OnGetAsync()
        {
            Customer = await _context.Customer.ToListAsync();
        }
    }
}
