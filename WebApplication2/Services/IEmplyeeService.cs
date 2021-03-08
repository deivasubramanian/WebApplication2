using System.Collections.Generic;
using DataLibrary.Queries;
using WebApplication2.Models;
using WebApplication2.Models.Employee;

namespace WebApplication2.Services
{
  public interface IEmployeeService 
  {
    EmployeeModel Get (int id);
    EmployeeModel Get (EmployeeQuery query);
    List<EmployeeModel> GetMany (EmployeeQuery query);

    EmployeeModel Update (EmployeeUpdate model);
    EmployeeModel Add (EmployeeAdd model);
    bool Delete (int id);
    bool Delete (EmployeeQuery query);
    bool DeleteMany (EmployeeQuery query);
  }
}