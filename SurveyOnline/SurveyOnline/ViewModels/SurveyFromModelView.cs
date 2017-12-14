﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SurveyOnline.Models;

namespace SurveyOnline.ViewModels
{
    public class SurveyFromModelView
    {

        public Survey Survey { get; set; }
        public IEnumerable<Topic> Topics { get; set; }
    }
}