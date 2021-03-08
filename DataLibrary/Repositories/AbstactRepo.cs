using DataLibrary.DataAccess;

namespace DataLibrary.Repositories
{
  public class AbstractRepo 
  {
    protected EmployeeContext context;

    protected bool Save() 
    {
      return context.SaveChanges() >= 0;
    }
  }
}