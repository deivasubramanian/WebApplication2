using System.Collections.Generic;
using System.Linq;
using DataLibrary.Models;
using DataLibrary.Queries;
using DataLibrary.Repositories;
using WebApplication2.Models;
using WebApplication2.Models.Employee;

namespace WebApplication2.Services
{
  // Here in service we do complex work blending other service and repositories to fulfil our needs
  // We should rely in repositories to take care of getting and storeing all of our data
  public class EmployeeService : IEmployeeService
  {

    private readonly IBaseRepo<Employee, int, EmployeeQuery> repo;

    public EmployeeService(IBaseRepo<Employee, int, EmployeeQuery> repo) 
    {
      this.repo = repo;
    }

    // We can use a library like Auto mapper to make sure we don't need to do the below conversions
    private EmployeeModel Convert (Employee model) {
      return new EmployeeModel {
        Id = model.Id,
        FirstName = model.FirstName,
        LastName = model.LastName,
        Age = model.Age,
      };
    }

    private List<EmployeeModel> Convert (List<Employee> models) {
      return models.ConvertAll(x=> Convert(x));
    }

    private Employee Convert (EmployeeAdd model) {
      return new Employee {
        FirstName = model.FirstName,
        LastName = model.LastName,
        Age = model.Age
      };
    }

    private Employee Convert (EmployeeUpdate model) {
      return new Employee {
        Id = model.Id,
        FirstName = model.FirstName,
        LastName = model.LastName,
        Age = model.Age
      };
    }
    public EmployeeModel Add(EmployeeAdd model) => Convert(repo.Add(Convert(model)));
    public bool Delete(int id) => repo.Delete(id);
    public bool Delete(EmployeeQuery query) => repo.Delete(query);
    public bool DeleteMany(EmployeeQuery query) => repo.DeleteMany(query);
    public EmployeeModel Get(int id) => Convert(repo.Get(id));
    public EmployeeModel Get(EmployeeQuery query) => Convert(repo.Get(query));
    public List<EmployeeModel> GetMany(EmployeeQuery query) => Convert(repo.GetMany(query).ToList());
    public EmployeeModel Update(EmployeeUpdate model) => Convert(repo.Update(Convert(model)));
  }
}