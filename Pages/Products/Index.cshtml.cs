using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DairyFarm.Data;
using DairyFarm.Models;

namespace DairyFarm.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly DairyFarm.Data.DairyFarmContext _context;

        public IndexModel(DairyFarm.Data.DairyFarmContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}
