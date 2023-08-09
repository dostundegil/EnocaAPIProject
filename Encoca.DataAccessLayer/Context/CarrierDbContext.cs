using Encoca.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encoca.DataAccessLayer.Context
{
    public class CarrierDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=CarrierDb;User Id=sa;Password=kaan2000sv;TrustServerCertificate=True");
        }

        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<CarrierConfiguration> Configurations { get; set; }    
        public DbSet<Order> Orders { get; set; }
    }
}
