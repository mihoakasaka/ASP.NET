using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SurveyOnline.Models;

namespace SurveyOnline.ViewModels
{
    public class UserFormModelView

    {

        public User User { get; set; }
        public IEnumerable<Survey> Surveys { get; set; }
    }
}