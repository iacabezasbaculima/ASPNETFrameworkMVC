using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataLibrary.DataAccess
{
	public static class SqlDataAccess
	{
		/// <summary>
		/// Get the connection string to the SQL server 
		/// </summary>
		/// <param name="connectionName"></param>
		/// <returns></returns>
		public static string GetConnectionString(string connectionName = "MVCDemoDB")
		{
			return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
		}
		/// <summary>
		/// Get employees stored in database as a List collection.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="sql"></param>
		/// <returns></returns>
		public static List<T> LoadData<T>(string sql)
		{
			using (IDbConnection con = new SqlConnection(GetConnectionString()))
			{
				return con.Query<T>(sql).ToList();
			}
		}
		/// <summary>
		/// Save a new employee in database.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="sql"></param>
		/// <param name="data"></param>
		/// <returns></returns>
		public static int SaveData<T>(string sql, T data)
		{
			using (IDbConnection con = new SqlConnection(GetConnectionString()))
			{
				return con.Execute(sql, data);
			}
		}
	}
}
