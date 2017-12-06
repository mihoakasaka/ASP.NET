using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using System.Data.Entity;

namespace VidPlace.Controllers
{
    public class CustomerController : Controller
    {
        //class variable
        private ApplicationDbContext db;
       // class constructor
        public CustomerController()
            {
            db = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var custmers = db.Customers.Include(c=>c.MembershipType).ToList();
            return View(custmers);
        }

        

        [Route("detail/{id}")]
        public ActionResult Detail(int id)
        {


            Customer cust = db.Customers.Include(c=>c.MembershipType).SingleOrDefault(c=>c.ID == id);
            if (cust == null)
            {
                return HttpNotFound();
            }

            return View(cust);
        }

        // GET: Customer
        /************ Excercise ********
        public ActionResult Index()
        {

            IEnumerable<Customer> custList =GetCustomer();
            return View(custList);
        }
        private IEnumerable<Customer> GetCustomer()
        {
           return  new List<Customer> {
             new Customer() {Name="John", Address="123 Hadley",ID=1},
            new Customer() { Name = "Gracy Gold", Address = "123 Guy", ID = 2 }
        };
      
            
        }

        [Route("detail/{id}")]
        public ActionResult Detail(int id)
        {


            Customer cust = (from data in getCustomers()
                             where data.ID == id
                             select data).SingleOrDefault();
            if (cust == null) {
                return HttpNotFound();
            }

            return View(cust);
        }
      ****************************************************************/


    }
}