using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TimeTracker2.Models
{
    public class TimeTrackerDbContextInitializer : DropCreateDatabaseIfModelChanges<TimeTrackerDbContext>
    {
        protected override void Seed(TimeTrackerDbContext context)
        {
            Employee tempEmployee = new Employee();

            tempEmployee.ID = 1;
            tempEmployee.FirstName = "Barry";
            tempEmployee.LastName = "Allen";
            tempEmployee.Department = "IT";
            tempEmployee.HireDate = DateTime.Now.AddDays(-14);

            List<TimeCard> timecards = new List<TimeCard>
            {
                new TimeCard{ID = 1, submissionDate = DateTime.Now,
                MondayHours = 8, TuesdayHours = 9, WednesdayHours = 6, ThurdaydayHours =8,
                FridayHours = 10, SaturdayHours=0, SundayHours = 0},

                new TimeCard{ID = 2, submissionDate = DateTime.Now.AddDays(-7),
                MondayHours = 10, TuesdayHours = 10, WednesdayHours = 8, ThurdaydayHours =10,
                FridayHours = 10, SaturdayHours=0, SundayHours = 3}

            };

            tempEmployee.timeCards = timecards;

            context.Employees.Add(tempEmployee);
            base.Seed(context);
        }
    }
}