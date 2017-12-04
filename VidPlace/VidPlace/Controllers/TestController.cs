using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;


namespace VidPlace.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        // Get: getString
        public string getString() {

            return "Hello World, Welcome to MVC.";
        }

        public ActionResult GetView()
        {
            return View("MyView");
        }

        public ActionResult GetDeveloper()
        {
            return View("Developer");
        }


        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.Name = "John";
            c.Address = "123 5thAvenue";
            return c;
        }

      


    }

  
    }





