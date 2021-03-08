using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace DataLibrary.Models
{
    public class Employee
    {
        // Guid?
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(200)]
        public string LastName { get; set; }
        public int Age { get; set; }
        // Relationship to another table?
        public int Role { get; set; }
    }
}
