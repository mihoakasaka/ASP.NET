using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoRental.Models
{
    public class VideoRentalRepository
    {
        VideoRentalDBContext db = new VideoRentalDBContext();

       
        public List<Customer> GetAllEmployees()
        {
            List<Customer> allCust =
                (from data in db.Customers
                 select data).ToList();

            return allCust;
        }

        public Customer GetCustomerById(int id) {
            Customer cust = (from data in db.Customers
                             where data.ID == id
                             select data).SingleOrDefault();
            return cust;
        }

        public void UpdateCustomer(int ID, string FirstName, string LastName, string Address, string Phone) {
            Customer cust = (from data in db.Customers
                             where data.ID == ID
                             select data).SingleOrDefault();
            cust.FirstName = FirstName;
            cust.LastName = LastName;
            cust.Address = Address;
            cust.Phone = Phone;
            db.SaveChanges();
        }



        public void AddCustomer( string firstName, string lastName,
            string address, string phone)
        {
            Customer e = new Customer();
            
            e.FirstName = firstName;
            e.LastName = lastName;
            e.Address = address;
            e.Phone = phone;

            db.Customers.Add(e);
            db.SaveChanges();
        }

        public void AddNewMedia(string title, string type,
          int year)
        {
            Media m = new Media();
        
            m.Title = title;
            m.Type = type;
            m.ProducedYear = year;

            db.Medias.Add(m);
            db.SaveChanges();
        }


        public List<Media> GetMediaByTitle(string title) {
            List<Media> mediaList = (from data in db.Medias
                                   //  where clause 
                                     select data).ToList();

            return mediaList;
        }

    }
}