using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using VehicleManagement.Models;

namespace VehicleManagement.Data
{
    public class BaseRepository<T> where T : Base
    {
		protected string _connectionString = System.Environment.GetEnvironmentVariable("CONNECTION_STRING");

		public SqlConnection NewConnection()
		{
			var sqlConnection = new SqlConnection(this._connectionString);
			sqlConnection.Open();
			return sqlConnection;
		}

		public T GetById(string query, object param)
		{
			using (var connection = this.NewConnection())
			{
				var result = connection.QuerySingleOrDefault<T>(query, param);
				return result;
			}
		}

		public IEnumerable<T> GetAll(string query)
		{
			using (var connection = this.NewConnection())
			{
				var result = connection.Query<T>(query);
				return result;
			}
		}
		public void ExecuteNonQuery(string query)
		{
			using (var connection = this.NewConnection())
			{
				connection.Execute(query);
			}
		}

		public void ExecuteNonQuery(string query, object param)
        {
			using (var connection = this.NewConnection())
			{
				connection.Execute(query, param);
			}
		}
	}
}
