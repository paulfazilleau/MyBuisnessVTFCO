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
        private readonly MyBuisnessVTCO.Data.GarageContext _context;

        public IndexModel(MyBuisnessVTCO.Data.GarageContext context)
        {
            _context = context;
        }

        public string OMSort { get; set; }
        public string ImmatSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }
        public PaginatedList<Truck> Trucks { get; set; }
        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;
            OMSort = String.IsNullOrEmpty(sortOrder) ? "OM_desc" : "";
            ImmatSort = sortOrder == "Immatriculation" ? "immatriculation_desc" : "Immatriculation";
            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<Truck> trucksIQ = from s in _context.Trucks
                                         select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                trucksIQ = trucksIQ.Where(s => s.OM.Contains(searchString) || s.A_Immatriculation.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "OM":
                    trucksIQ = trucksIQ.OrderByDescending(s => s.OM);
                    break;
                case "Immatriculation":
                    trucksIQ = trucksIQ.OrderBy(s => s.A_Immatriculation);
                    break;
                case "immatriculation_desc":
                    trucksIQ = trucksIQ.OrderByDescending(s => s.A_Immatriculation);
                    break;
                default:
                    trucksIQ = trucksIQ.OrderBy(s => s.OM);
                    break;
            }

            int pageSize = 3;
            Trucks = await PaginatedList<Truck>.CreateAsync(
                trucksIQ.AsNoTracking(), pageIndex ?? 1, pageSize);
        }
    }
}
