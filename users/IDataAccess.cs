using System.Collections.Generic;
using System.Threading.Tasks;

namespace react_dotnet_example
{
    public interface IDataAccess
    {
        Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString);
        Task SaveData<T, U>(string sql, T parameters, string connectionString);
    }
}