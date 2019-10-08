using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyBuisnessVTCO.Models;

namespace MyBuisnessVTCO.Data
{
    public class BuisnessContext : DbContext
    {
        public BuisnessContext (DbContextOptions<BuisnessContext> options)
            : base(options)
        {
        }
        public DbSet<Truck> Trucks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Truck>().ToTable("Trucks");
        }
    }
}
