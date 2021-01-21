using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace VehicleManagement.Data
{
    public class RepositoryBase<T>
    {
		protected string _connectionString = System.Environment.GetEnvironmentVariable("CONNECTION_STRING");

		public SqlConnection NewConnection()
		{
			var sqlConnection = new SqlConnection(this._connectionString);
			sqlConnection.Open();
			return sqlConnection;
		}

		public T Get(string query, object param)
		{
			using (var connection = this.NewConnection())
			{
				var result = connection.QuerySingleOrDefault<T>(query, param);
				return result;
			}
		}

		public List<T> List(string query)
		{
			using (var connection = this.NewConnection())
			{
				var result = connection.Query<T>(query);
				var objectList = result != null ? result.ToList() : null;
				return objectList;
			}
		}
	}
}
