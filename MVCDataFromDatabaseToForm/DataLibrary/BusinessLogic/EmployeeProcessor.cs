using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.DataAccess;
using DataLibrary.Models;


namespace DataLibrary.BusinessLogic
{
	public static class EmployeeProcessor
	{
		/// <summary>
		/// Insert a new employee into database.
		/// </summary>
		/// <param name="employeeId"></param>
		/// <param name="firstName"></param>
		/// <param name="lastName"></param>
		/// <param name="emailAddress"></param>
		/// <returns></returns>
		public static int CreateEmployee(int employeeId, string firstName, string lastName, string emailAddress)
		{
			EmployeeDBModel data = new EmployeeDBModel
			{
				EmployeeId = employeeId,
				FirstName = firstName,
				LastName = lastName,
				EmailAddress = emailAddress
			};

			string sql = @"insert into dbo.Employee (EmployeeId, FirstName, LastName, EmailAddress)
						values (@EmployeeId, @FirstName, @LastName, @EmailAddress);";

			return SqlDataAccess.SaveData(sql, data);
		}
		/// <summary>
		/// Select all data from Employee table.
		/// </summary>
		/// <returns></returns>
		public static List<EmployeeDBModel> LoadEmployees()
		{
			string sql = @"select Id, EmployeeId, FirstName, LastName, EmailAddress
							from dbo.Employee";
			return SqlDataAccess.LoadData<EmployeeDBModel>(sql);
		}
	}
}
