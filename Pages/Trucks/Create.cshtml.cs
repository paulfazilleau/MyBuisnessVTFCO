using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyBuisnessVTCO.Data;
using MyBuisnessVTCO.Models;

namespace MyBuisnessVTCO.Pages.Trucks
{
    public class CreateModel : PageModel
    {
        private readonly MyBuisnessVTCO.Data.BuisnessContext _context;

        public CreateModel(MyBuisnessVTCO.Data.BuisnessContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Truck Trucks { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Trucks.Add(Trucks);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
