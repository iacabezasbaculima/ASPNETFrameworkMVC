using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
	public class EmployeeModel
	{
		[Display(Name = "Employee ID")]
		[Range(100000, 999999, ErrorMessage = "Employee ID must contain six numbers.")]
		public int EmployeeId { get; set; }

		[Display(Name = "First Name")]
		[Required(ErrorMessage = "Please enter a first name.")]
		public string FirstName { get; set; }

		[Display(Name = "Last Name")]
		[Required(ErrorMessage = "Please enter a last name.")]
		public string LastName { get; set; }

		[DataType(DataType.EmailAddress)]
		[Display(Name = "Email Address")]
		[Required(ErrorMessage = "Please enter a valid email address.")]
		public string EmailAddress { get; set; }

		[Display(Name = "Confirm Email")]
		[Compare("EmailAddress", ErrorMessage = "Email address and confirm email must match.")]
		public string ConfirmEmail { get; set; }

		[DataType(DataType.Password)]
		[Display(Name = "Password")]
		[Required(ErrorMessage = "Please enter a password.")]
		[StringLength(100, MinimumLength = 10, ErrorMessage = "Password must contain at least 10 characters.")]
		public string Password { get; set; }

		[Display(Name = "Confirm Password")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Password and confirm password must match.")]
		public string ConfirmPassword { get; set; }

	}
}