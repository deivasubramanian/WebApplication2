
using DataLibrary.Queries;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models.Employee;
using WebApplication2.Services;

namespace WebApplication2.Api
{
  [Route("api/[controller]")]
  [ApiController]
  public class EmployeeController : ControllerBase
  {
    private IEmployeeService service;

    public EmployeeController(IEmployeeService service)
    {
      this.service = service;
    }

    [HttpGet]
    public IActionResult GetById(int id)
    {
      return Ok(service.Get(id));
    }

    [HttpGet]
    public IActionResult GetByQuery([FromBody] EmployeeQuery query)
    {
      return Ok(service.Get(query));
    }

    [HttpPost]
    public IActionResult Add([FromBody] EmployeeAdd model)
    {
      return Ok(service.Add(model));
    }

    [HttpPut]
    public IActionResult SignUp([FromBody] EmployeeUpdate model)
    {
      return Ok(service.Update(model));
    }

    [HttpDelete]
    public IActionResult DeleteById(int id)
    {
      return Ok(service.Delete(id));
    }

    [HttpDelete]
    public IActionResult DeleteByQuery([FromBody] EmployeeQuery query)
    {
      return Ok(service.Delete(query));
    }
  }
}
