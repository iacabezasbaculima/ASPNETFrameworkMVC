﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
	/// <summary>
	/// A description of the data stored in the database
	/// </summary>
	public class EmployeeDBModel
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
	}
}
