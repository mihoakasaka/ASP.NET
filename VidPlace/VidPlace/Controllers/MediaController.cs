using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.Models;
using VidPlace.ViewModels;

namespace VidPlace.Controllers
{
    public class MediaController : Controller
    {
        public ActionResult Index()
        {

            List<Media> mediaList = (from m in GetAllMedia()
                                       select m).ToList();
            return View(mediaList);
        }
        public List<Media> GetAllMedia()
        {
            List<Media> list = new List<Media> {
             new Media() {ID=123, Name="Avatar"},
            new Media() {ID=456, Name = "Pinocchio"}
        };
            return list;

        }

       

        public ActionResult RandomeViewData()
        {
            Media m = new Media();
            m.ID = 111;
            m.Name = "Inception";

            ViewData["mediaObject"] = m;
            return View(m);
        }

        public ActionResult ListCustomers()
            {
             var m = new Media(){Name="Pulp Fiction"};
            var custs = new List<Customer>
            {
                new Customer(){ Name="Barry Alan"},
                new Customer() { Name = "Jerry Tom" },
                new Customer() { Name = "Andy Alan" }
        };
            var viewModelObj = new customerMediaViewModel()
            {
                media = m,
                customersList = custs
            };

            return View(viewModelObj);


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

        [Route("media/index/{page:min(1)}/{sortBy:alpha}")]
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


        //released action with attribute route
        [Route("media/released/{year:range(1900,2017)}/{month:range(1,12)}")]
        public ActionResult Released(int year, int month)
        {

         

            return Content("Released year : " + year + "    Month:" + month);
        }

    }

}