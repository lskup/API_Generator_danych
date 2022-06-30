using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DatabaseAccess.DbAccess;

public class SqlAccess : ISqlAccess
{
    private readonly IConfiguration _configuration;

    public SqlAccess(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task SaveData<T>(string sql, T parameters, string connectionString = "Default")
    {
        using IDbConnection dbConnection = new SqlConnection(_configuration.GetConnectionString(connectionString));
        await dbConnection.ExecuteAsync(sql, parameters, commandType: CommandType.Text);
    }




}
