using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace LocalBusinessDirectory.Data.Sql;
public class SqlAccess : ISqlAccess
{
    private readonly IConfiguration _config;

    public SqlAccess(IConfiguration config)
    {
        _config = config;
    }

    public async Task<List<T>> GetAsync<T>(string storedProcedure, object parameters)
    {
        using var connection = new SqlConnection(_config.GetConnectionString("default"));

        var result = await connection.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
        return result.ToList();
    }

    public async Task<List<T>> GetAsync<T, TFirst, TSecond>(string storedProcedure, object parameters, Func<TFirst, TSecond, T> map)
    {
        using var connection = new SqlConnection(_config.GetConnectionString("default"));

        var result = await connection.QueryAsync(storedProcedure, map, parameters, commandType: CommandType.StoredProcedure);
        return result.ToList();
    }

    public async Task<T> GetFirstOrDefaultAsync<T>(string storedProcedure, object parameters)
    {
        using var connection = new SqlConnection(_config.GetConnectionString("default"));

        return await connection.QueryFirstOrDefaultAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task ExecuteAsync(string storedProcedure, object parameters)
    {
        using var connection = new SqlConnection(_config.GetConnectionString("default"));

        await connection.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }
}
