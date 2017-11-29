using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimeTracker.Models
{
    public class TimeTrackerRepository
    {
        TimeTrackerDBContext _context = new TimeTrackerDBContext();
        public List<Employee> getAllEmployees()
        {

            List<Employee> allEmps =
                (from data in _context.Employees
                 select data).ToList();
            return allEmps;
        }

        public List<TimeCard> getTimeCardsById(int empId)
        {

            List<TimeCard> timecards =
                (from data in _context.Employees
                 where (data.ID == empId)
                 select data.timeCards).SingleOrDefault();
            return timecards;
        }

        public List<string> getAllDepartment()
        {
            List<string> departments = (from data in _context.Employees
                                        select data.Department).Distinct().ToList();
            return departments;
        }

        public List<Employee> getAllEmployeesByDepartment(string dept)
        {

            List<Employee> allEmps =
                (from data in _context.Employees
                 where data.Department == dept
                 select data).ToList();
            return allEmps;
        }

        public List<string> getEmployeesByDepartment(string dept)
        {

            List<string> allEmps =
                (from data in _context.Employees
                 where data.Department == dept
                 select data.FirstName).ToList();
            return allEmps;
        }

        public Employee getEmployeeById(int id)
        {

            Employee emp =
                (from data in _context.Employees
                 where data.ID == id
                 select data).SingleOrDefault();
            return emp;
        }

         public void addEmployee(int ID, string FirstName, string LastName, string Department, DateTime HireDate) {
           
             Employee newEmp = new Employee();
            newEmp.ID = ID;
            newEmp.FirstName = FirstName;
            newEmp.LastName = LastName;
            newEmp.Department = Department;
            newEmp.HireDate = HireDate;
             _context.Employees.Add(newEmp);
         }
    }
}