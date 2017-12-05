using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace VideoRental.Models
{
    public class VideoRentalDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RentalRecord> RentalRecords { get; set; }
        public DbSet<Media> Medias { get; set; }

    }
  
}