using System;
using System.ComponentModel.DataAnnotations;

namespace MyBuisnessVTCO.Models.GarageViewModels
{
    public class ReservationDateTruck
    {
        [DataType(DataType.Date)]
        public DateTime? ReservationDate { get; set; }

        public int TruckCount { get; set; }
    }
}
