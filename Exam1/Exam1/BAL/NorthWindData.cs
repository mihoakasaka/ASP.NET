using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exam1.DATA;

namespace Exam1.BAL
{
    public class NorthWindData
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public List<Order> getOrdersByOrderDate(DateTime orderDate)
        {
            List <Order> orderList = (from o in db.Orders
                                      where (o.OrderDate == orderDate)
                                      select o).ToList();

            return orderList;

        }

        public Customer getCustomerById(string custId) {

            Customer cust = (from c in db.Customers
                             where c.CustomerID == custId
                             select c).SingleOrDefault();
            return cust;
        }
        

         }
    }
