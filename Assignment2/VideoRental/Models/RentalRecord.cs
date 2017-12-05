using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRental.Models
{
    public class RentalRecord
    {
        public int ID { get; set; }
       public DateTime RentDate  { get; set; }
        public List<Media> MediaList { get; set; }
    }
}