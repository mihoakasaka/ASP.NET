using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidPlace.ViewModels;
using VidPlace.Models;

namespace VidPlace.Controllers
{
    public class RentalsController : Controller
    {
        //Class variables
        private ApplicationDbContext _context;

        //Class contructor
        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Rentals
        public ActionResult Index()
        {
            return View();
        }

        //GET : Rentals/Create
        public ActionResult Create(int id, string SearchString)
        {
            var viewModel = new RentalFormViewModel();

            viewModel.Customer = _context.Customers.Find(id);
            if (viewModel.Customer == null)
                return HttpNotFound();

            if(!String.IsNullOrWhiteSpace(SearchString))
            {
                viewModel.Medias = _context.Medias.Where(m => m.name.Contains(SearchString)).ToList();
            }
            
            return View(viewModel);
        }

        //POST : Rentals/Create
        [HttpPost]
        public ActionResult Create()
        {
            return View("RentalConfirmation");
        }


        }
}