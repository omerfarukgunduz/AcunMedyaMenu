﻿using AcunMedyaMenu.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaMenu.Context
{
    public class MenuContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-RSDLUJ4; initial catalog=AcunMedyaMenuDb; integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
