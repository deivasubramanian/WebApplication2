using DataLibrary;
using DataLibrary.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService service;
        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View();
        }

        /*
        [HttpPost]
        public  IActionResult Save(EmployeeModel employee)
        {
            EmployeeSaveService.SaveEmployee(employee.FirstName, employee.lastname, employee.Age);
          
            return new JsonResult(employee); // this is mvc controller, we need to return a view!
        }
        */
    }
}
