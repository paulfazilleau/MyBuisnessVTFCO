using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyBuisnessVTCO.Data;
using MyBuisnessVTCO.Models;

namespace MyBuisnessVTCO.Pages.Trucks
{
    public class DeleteModel : PageModel
    {
        private readonly MyBuisnessVTCO.Data.BuisnessContext _context;

        public DeleteModel(MyBuisnessVTCO.Data.BuisnessContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Truck Trucks { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trucks = await _context.Trucks.FirstOrDefaultAsync(m => m.ID == id);

            if (Trucks == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Trucks = await _context.Trucks.FindAsync(id);

            if (Trucks != null)
            {
                _context.Trucks.Remove(Trucks);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
