using DataLibrary.DataAccess;
using DataLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary
{
    public class EmployeeSave : IEmployeeSave
    {

        private readonly EmployeeContext context;
        public EmployeeSave(EmployeeContext dbContext)
        {
            context = dbContext;

        }
        public bool SaveEmployee(string FirstName, string LastName, int Age)
        {
            Employee newEmplyee = new Employee()
            { Age = Age, FirstName = FirstName, LastName = LastName };
            context.Add(newEmplyee);
            context.SaveChanges();
            return true;
        }
    }
}
