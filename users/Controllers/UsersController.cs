using System;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MySql.Data.MySqlClient;


namespace react_dotnet_example.Controllers
{
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly string connString;
        private readonly ILogger<UsersController> _logger;



        public UsersController(IConfiguration configuration, ILogger<UsersController> logger)
        {
            _configuration = configuration;
            _logger = logger;
            //database
            var host = _configuration["DATABASE_HOST"] ?? "database";
            var password = _configuration["MYSQL_ROOT_PASSWORD"] ?? "dbuserpassword";
            var userid = _configuration["MYSQL_USER"] ?? "dbuser";
            connString = $"server={host};port=3306;userid={userid};password={password};database=users_prod;";

        }

        [HttpGet]
        [Route("api/users")]
        public async Task<IActionResult> Index()
        {

            string sql = "SELECT * from owner";
            try
            {
                using (var connection = new MySqlConnection(connString))
                {
                    var owner = await connection.QueryAsync<Owner>(sql);
                    return Ok(owner);
                }
            }
            catch (Exception)
            {
                return Ok(connString);
            }


        }


    }
}
