using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SurveyOnline.Models;
using SurveyOnline.ViewModels;
using System.Data.Entity;

namespace SurveyOnline.Controllers
{
    public class SurveyController : Controller
    { 
        private ApplicationDbContext _context;

        //Class contructor
        public SurveyController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Survey
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult New()
        {
            //var membershipTypes = _context.MembershipTypes.ToList();

            var viewModel = new SurveyFromModelView()
            {
                Survey = new Survey(),
                Topics = _context.Topics.ToList()
            };
            return View("SurveyForm", viewModel);
        }

        //Adding a new survey -  http post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Survey survey)
        {
            //Server side validation - start
            if (!ModelState.IsValid)
            {
                var viewModel = new SurveyFromModelView()
                {
                    Survey = survey,
                    Topics = _context.Topics.ToList()
                };

                return View("SurveyForm", viewModel);
            }
            //**********Server side validation - end *********
            if (survey.ID == 0)
            {
                _context.Surveys.Add(survey);
            }
            else
            {
                var surveyInDB = _context.Surveys.Single(s => s.ID == survey.ID);
                /*
                 * TryUpdateModel(surveyInDB);
                 * this is defualt method to update used by MS
                 * It has major security flow.
                 * 
                 * */
                //This manual way to it.
                surveyInDB.Title = survey.Title;
                surveyInDB.SurveyQuestion = survey.SurveyQuestion;
                surveyInDB.TopicId = survey.TopicId;
                surveyInDB.Autohor = survey.Autohor;
                surveyInDB.Deadline = survey.Deadline;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Surveys");
        }

        public ActionResult List()
        {
            var surveys = _context.Surveys.Include(s=>s.Topic).ToList();
            return View(surveys);
        }
    }
}