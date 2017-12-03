using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRental.Models
{
    public class VideoRentalRepository
    {
        VideoRentalDBContext db = new VideoRentalDBContext();

       
        public List<Customer> getAllEmployees()
        {
            List<Customer> allCust =
                (from data in db.Customers
                 select data).ToList();

            return allCust;
        }

        public Customer getCustomerById(int id) {
            Customer cust = (from data in db.Customers
                             where data.ID == id
                             select data).SingleOrDefault();
            return cust;
        }

        public void updateCustomer(Customer c) {
            Customer cust = (from data in db.Customers
                             where data.ID == c.ID
                             select data).SingleOrDefault();
            cust.FirstName = c.FirstName;
            cust.LastName = c.LastName;
            cust.Address = c.Address;
            cust.Phone = c.Phone;
        }



        public void addCustomer(int ID, string firstName, string lastName,
            string address, string phone)
        {
            Customer e = new Customer();
            e.ID = ID;
            e.FirstName = firstName;
            e.LastName = lastName;
            e.Address = address;
            e.Phone = phone;

            db.Customers.Add(e);
            db.SaveChanges();
        }

        public void addNewMedia(int ID, string title, string type,
          int year)
        {
            Media m = new Media();
            m.ID = ID;
            m.Title = title;
            m.Type = type;
            m.ProducedYear = year;

            db.Medias.Add(m);
            db.SaveChanges();
        }


        public List<Media> getMediaByTitle(string title) {
            List<Media> mediaList = (from data in db.Medias
                                   //  where clause 
                                     select data).ToList();

            return mediaList;
        }

    }
}