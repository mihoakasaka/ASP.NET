using Phono.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Phono.Controllers
{
    public class PhonesController : Controller
    {
        //Class variables
        private ApplicationDbContext _context;

        //Class contructor
        public PhonesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Phones
        public ActionResult Index()
        {
            var phones = _context.Phones.ToList();
            return View(phones);
        }
    }
}