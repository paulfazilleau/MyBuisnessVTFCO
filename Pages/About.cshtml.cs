using MyBuisnessVTCO.Models.GarageViewModels;
using MyBuisnessVTCO.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBuisnessVTCO.Models;

namespace MyBuisnessVTCO.Pages
{
    public class AboutModel : PageModel
    {
        private readonly MyBuisnessVTCO.Data.BuisnessContext _context;

        public AboutModel(MyBuisnessVTCO.Data.BuisnessContext context)
        {
            _context = context;
        }

        public IList<ReservationDateTruck> Trucks { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<ReservationDateTruck> data =
                from truck in _context.Trucks
                group truck by truck.ReservationDate into dateGroup
                select new ReservationDateTruck()
                {
                    ReservationDate = dateGroup.Key,
                    TruckCount = dateGroup.Count()
                };

            Trucks = await data.AsNoTracking().ToListAsync();
        }
    }
}