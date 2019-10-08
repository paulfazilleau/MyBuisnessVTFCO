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
    public class IndexModel : PageModel
    {
        private readonly MyBuisnessVTCO.Data.BuisnessContext _context;

        public IndexModel(MyBuisnessVTCO.Data.BuisnessContext context)
        {
            _context = context;
        }

        public IList<Truck> Trucks { get;set; }

        public async Task OnGetAsync()
        {
            Trucks = await _context.Trucks.ToListAsync();
        }
    }
}
