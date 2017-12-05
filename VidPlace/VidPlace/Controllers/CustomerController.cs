using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {

            List<Customer> custList =  (from cust in GetCustomer()
                                               select cust).ToList();
            return View(custList);
        }
        public List<Customer> GetCustomer()
        {
            List<Customer> list = new List<Customer> {
             new Customer() {Name="John", Address="123 Hadley",ID=777},
            new Customer() { Name = "Gracy Gold", Address = "123 Guy", ID = 111 }
        };
            return list;
            
        }

        [Route("detail/{id}")]
        public ActionResult Detail(int id)
        {


            Customer cust = (from data in GetCustomer()
                             where data.ID == id
                             select data).SingleOrDefault();
            if (cust == null) {
                return HttpNotFound();
            }

            return View(cust);
        }
      


    }
}