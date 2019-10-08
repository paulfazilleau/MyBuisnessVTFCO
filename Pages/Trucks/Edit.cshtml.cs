using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyBuisnessVTCO.Data;
using MyBuisnessVTCO.Models;

namespace MyBuisnessVTCO.Pages.Trucks
{
    public class EditModel : PageModel
    {
        private readonly MyBuisnessVTCO.Data.BuisnessContext _context;

        public EditModel(MyBuisnessVTCO.Data.BuisnessContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Trucks).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TrucksExists(Trucks.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TrucksExists(int id)
        {
            return _context.Trucks.Any(e => e.ID == id);
        }
    }
}
