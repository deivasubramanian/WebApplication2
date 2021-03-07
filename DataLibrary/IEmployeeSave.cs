using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary
{
   public interface IEmployeeSave
    {
        bool SaveEmployee(string FirstName, string LastName, int Age);
    }
}
