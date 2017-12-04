using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class MediaController : Controller
    {
        // GET: Media
        public ActionResult Index1()
        {
            return View();
        }

        public ActionResult Randome()
        {

            Media result = new Media();

            result.Name = "Star Wars";
            return View(result);
        }

        public ActionResult ActionResultContent()
        {
            return Content("Hello World");

        }


        public ActionResult ActionResultHttpNotFound()
        {
            return HttpNotFound();

        }


        public ActionResult ActionResultEmpty()
        {
            return new EmptyResult();

        }


        public ActionResult ActionResultRedirect()
        {
           // return RedirectToAction("GetCustomer","Customer");
            return RedirectToAction("GetCustomer", "Customer", new { page =1,sortBy="name"});// query string
        }


        public ActionResult edit(int id)
        {
            return Content("Provided ID =" + id);
        }


        public ActionResult Index(int? pageIndex, string sortBy)// to make an int parameter optional, put '?' after "int"
        {

            if (!pageIndex.HasValue)//int can not be null. provide default value to avoid an error.
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }
         return Content("PageNo."+pageIndex+"Sort by "+sortBy) ;
          
        }

    }
}