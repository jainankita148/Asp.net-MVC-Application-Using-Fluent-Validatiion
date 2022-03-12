using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFluentValidationDemo.Models
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First Name is Required");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last Name is Required");
            RuleFor(x => x.CompanyName).NotEmpty().WithMessage("Company Name is Required");
            RuleFor(x => x.DOB).NotEmpty().WithMessage("Date of Birth is Required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is Required");
            RuleFor(x => x.Salary).NotEmpty().WithMessage("Salary is Required");

            RuleFor(x => x.CompanyName).Length(5, 500).WithMessage("Company Name must be between 0 to 500 character");
            RuleFor(x => x.DOB).Must(ValidateAge).WithMessage("Employee age must be 18 or greater than 18");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Email is not valid");
            RuleFor(x => x.Salary).GreaterThan(1000).WithMessage("Employee Salary should be greater than 1000");
        }
        private bool ValidateAge(DateTime age)
        {
            DateTime dateTime = DateTime.Today;
            int actualAge = dateTime.Year - Convert.ToDateTime(age).Year;
            if (actualAge < 18)
            {
                return false;
            }
            return true;
        }
    }
}