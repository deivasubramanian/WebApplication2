using DataLibrary;
using DataLibrary.DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeSave EmployeeSaveService;
        public EmployeeController(IEmployeeSave SaverService)
        {
            EmployeeSaveService = SaverService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult Save(EmployeeModel employee)
        {
            EmployeeSaveService.SaveEmployee(employee.FirstName, employee.lastname, employee.Age);
          
            return new JsonResult(employee);
        }
    }
}
