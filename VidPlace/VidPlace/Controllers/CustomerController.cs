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
            return View();
        }
        public ActionResult GetCustomer()
        {
            Customer cust = new Customer() {Name="John", Address="123 Hadley",ID=777};

            return View(cust);
        }
    }
}