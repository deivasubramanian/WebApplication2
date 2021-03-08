using System.Collections.Generic;
using System.Linq;
using DataLibrary.DataAccess;
using DataLibrary.Models;
using DataLibrary.Queries;

namespace DataLibrary.Repositories
{
  public class EmployeeRepo : AbstractRepo, IBaseRepo<Employee, int, EmployeeQuery>
  {
    public EmployeeRepo(EmployeeContext context)
    {
      this.context = context;
    }

    public Employee Add(Employee model)
    {
      var response = context.Employees.Add(model);
      var result = Save();

      if (result)
      {
        return response.Entity;
      }
      else throw new RepositoryException("Failed to add a employee to the database");
    }

    public bool Delete(int id)
    {
      var result = Get(id);
      context.Employees.Remove(result);
      return Save();
    }

    public bool Delete(EmployeeQuery query)
    {
      var result = Get(query);
      context.Employees.Remove(result);
      return Save();
    }

    public bool DeleteMany(EmployeeQuery query)
    {
      var result = GetMany(query);
      context.Employees.RemoveRange(result);
      return Save();
    }

    public Employee Get(int id) => context.Employees.FirstOrDefault(x => x.Id == id);

    private IQueryable<Employee> MakeQuery(EmployeeQuery query)
    {
      
      var q = context.Employees.AsQueryable();

      if (query.Id != null)
      {
        q = q.Where(x => x.Id == query.Id);
      }
      if (query.FirstName != null)
      {
        q = q.Where(x => x.FirstName.ToLower().Contains(query.FirstName.ToLower()));
      }
      if (query.LastName != null)
      {
        q = q.Where(x => x.LastName.ToLower().Contains(query.LastName.ToLower()));
      }
      if (query.Age != null)
      {
        q = q.Where(x => x.Age == query.Age);
      }
      if (query.AgeRange != null)
      {
        if (query.AgeRange.Min != null && query.AgeRange.Max != null)
        {
          q = q.Where(x => x.Age >= query.AgeRange.Min && x.Age<= query.AgeRange.Max);
        }
        else if (query.AgeRange.Min != null)
        {
          q = q.Where(x => x.Age >= query.AgeRange.Min);
        }
        else if (query.AgeRange.Max != null)
        {
          q = q.Where(x => x.Age<= query.AgeRange.Max);
        }
      }
      if (query.Role != null)
      {
        q = q.Where(x => x.Role == query.Role);
      }

      return q;
    }
    public Employee Get(EmployeeQuery query)
    {
      return MakeQuery(query).FirstOrDefault();
    }

    public IEnumerable<Employee> GetMany(EmployeeQuery query)
    {
      return MakeQuery(query).ToList();
    }

    public Employee Update(Employee model)
    {
      var response = context.Employees.Update(model);
      var result = Save();

      if (result)
      {
        return response.Entity;
      }
      else throw new RepositoryException("Failed to update a employee in the database");
    }
  }
}