using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTracker2.Models
{
    public class TimeTrackeRepository
    {
        TimeTrackerDbContext _context = new TimeTrackerDbContext();
        
        /*
         * This methods gets the records of all employees
         * */
        public List<Employee> getAllEmployees()
        {
            List<Employee> allEmps =
                (from data in _context.Employees
                 select data).ToList();

            return allEmps;
        }

        public List<TimeCard> getemployeeTimeCard(int empID)
        {
            List<TimeCard> mytimeCards =
                (from data in _context.Employees
                 where data.ID == empID
                 select data.timeCards).SingleOrDefault();
            return mytimeCards;
        }

        public List<string> getDepartments()
        {
            List<string> myDepartments =
                (from data in _context.Employees
                 select data.Department).Distinct().ToList();

            return myDepartments;
        }

        public List<Employee> getAllEmployeesbyDepartment(string department)
        {
            List<Employee> allEmps =
                (from data in _context.Employees
                 where data.Department == department
                 select data).ToList();

            return allEmps;
        }

        public Employee getemployee(int empID)
        {
            Employee myEmp =
                (from data in _context.Employees
                 where data.ID == empID
                 select data).SingleOrDefault();
            return myEmp;
        }

        public void insertEmployee(int ID, string firstName, string lastName,
            string department, DateTime hiredate)
        {
            Employee e = new Employee();
            e.ID = ID;
            e.FirstName = firstName;
            e.LastName = lastName;
            e.Department = department;
            e.HireDate = hiredate;

            _context.Employees.Add(e);
            _context.SaveChanges();
        }
    }
}