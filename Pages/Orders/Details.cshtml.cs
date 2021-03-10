using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DairyFarm.Data;
using DairyFarm.Models;

namespace DairyFarm.Pages.Orders
{
    public class DetailsModel : PageModel
    {
        private readonly DairyFarm.Data.DairyFarmContext _context;

        public DetailsModel(DairyFarm.Data.DairyFarmContext context)
        {
            _context = context;
        }

        public Order Order { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Order = await _context.Order
                .Include(o => o.Customer)
                .Include(o => o.Product).FirstOrDefaultAsync(m => m.ID == id);

            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
