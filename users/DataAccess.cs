using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;

namespace react_dotnet_example
{


    public class DataAccess : IDataAccess
    {
        //string sql -> T
        //U Parameters -> U
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                // T = select * ill be a set of those on per row

                var rows = await connection.QueryAsync<T>(sql, parameters);

                return rows.ToList();

            }

        }

        public Task SaveData<T, U>(string sql, T parameters, string connectionString)
        {
            using (IDbConnection connection = new MySqlConnection(connectionString))
            {
                return connection.ExecuteAsync(sql, parameters);
            }

        }
    }
}