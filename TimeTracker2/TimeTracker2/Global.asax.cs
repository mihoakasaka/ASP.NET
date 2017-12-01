﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data.Entity;
using TimeTracker2.Models;

namespace TimeTracker2
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TimeTrackerDbContext>());
            Database.SetInitializer(new TimeTrackerDbContextInitializer());
        }
    }
}