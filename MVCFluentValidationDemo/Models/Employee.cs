using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFluentValidationDemo.Models
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }
    }
}