using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurveyOnline.Models;
using SurveyOnline.ViewModels;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

using System.Net;


namespace SurveyOnline.Controllers
{
    public class UsersController : Controller
    {

        private ApplicationDbContext _context;

        //Class contructor
        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Users
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListSurveys()
        {
            var surveys = _context.Surveys.Include(s => s.Topic).ToList();
            return View(surveys);
        }

        public ActionResult Answer(int surveyId)
        {
            
                //var membershipTypes = _context.MembershipTypes.ToList();

                var viewModel = new UserFormModelView()
                {
                    User = new User(),
                    Surveys = _context.Surveys.ToList()
                };
                return View("CustomerForm", viewModel);
            }

       

    }

}