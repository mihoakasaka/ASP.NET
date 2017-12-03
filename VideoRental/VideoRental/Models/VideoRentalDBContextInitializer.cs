using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VideoRental.Models
{
    public class VideoRentalDBContextInitializer : DropCreateDatabaseIfModelChanges<VideoRentalDBContext>
    {
        protected override void Seed(VideoRentalDBContext context)
        {
            Media media1 = new Media();
            Media media2 = new Media();
            Media media3 = new Media();
            Media media4 = new Media();

            media1.ID = 1;
            media1.Title = "Avater";
            media1.Type = "SF";
            media1.ProducedYear = 2009;

            media2.ID = 2;
            media2.Title = "Mask";
            media2.Type = "Comedy";
            media2.ProducedYear = 1994;

            media3.ID = 3;
            media3.Title = "Titanic";
            media3.Type = "Drama";
            media3.ProducedYear = 1997;

            media2.ID = 4;
            media2.Title = "Mad Max";
            media2.Type = "Action";
            media2.ProducedYear = 2015;

            List<Media> medias1 = new List<Media> { media1, media2 };

            List<Media> medias2 = new List<Media> { media3, media4 };

            Customer tempCust = new Customer();

            tempCust.ID = 1;
            tempCust.FirstName = "Barry";
            tempCust.LastName = "Allen";
            tempCust.Address = "123 Montagne";
            tempCust.Phone = "514-123-4567";

            List<RentalRecord> records = new List<RentalRecord>
            {
                new RentalRecord{ID = 1, RentDate = DateTime.Now.AddDays(-30), MediaList=medias1 },
            new RentalRecord { ID = 2, RentDate = DateTime.Now.AddDays(-10), MediaList = medias2 }
             
            };

            tempCust.RentalRecords = records;

            context.Customers.Add(tempCust);
            base.Seed(context);
        }
    }
}