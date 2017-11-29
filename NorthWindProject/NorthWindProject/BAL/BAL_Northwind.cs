using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthWindProject.Data;

namespace NorthWindProject.BAL
{
    public class BAL_Northwind
    {
        public List<string> getCountries()
        {
            using (var context = new NorthWindDataContext())
            {
                List<string> myList = (from data in context.Customers select data.Country).Distinct().ToList();
                return myList;
            }
        }


        public List<Customer> getAllCustomer(string Country)
        {
            using (var context = new NorthWindDataContext())
            {
                List<Customer> allCustomers = (from data in context.Customers
                                               where data.Country == Country
                                               select data).ToList();
                return allCustomers;
            }


        }


        public Customer GetCustomer(string customerID) {
            using (var context = new NorthWindDataContext()) {
                Customer customer = (from data in context.Customers
                                     where data.CustomerID == customerID
                                     select data).SingleOrDefault();
                return customer;
            }

        }

    }
}