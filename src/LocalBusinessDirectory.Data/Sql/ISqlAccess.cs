namespace LocalBusinessDirectory.Data.Sql;

public interface ISqlAccess
{
    Task ExecuteAsync(string storedProcedure, object parameters);
    Task<List<T>> GetAsync<T>(string storedProcedure, object parameters);
    Task<List<T>> GetAsync<T, TFirst, TSecond>(string storedProcedure, object parameters, Func<TFirst, TSecond, T> map, string splitOn = "Id");
    Task<List<T>> GetAsync<T, TFirst, TSecond, TThird>(string storedProcedure, object parameters, Func<TFirst, TSecond, TThird, T> map, string splitOn = "Id");
    Task<T?> GetFirstOrDefaultAsync<T>(string storedProcedure, object parameters);
}