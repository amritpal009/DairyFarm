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
    public class DetailsModel : PageModel
    {
        private readonly DairyFarm.Data.DairyFarmContext _context;

        public DetailsModel(DairyFarm.Data.DairyFarmContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.ID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
