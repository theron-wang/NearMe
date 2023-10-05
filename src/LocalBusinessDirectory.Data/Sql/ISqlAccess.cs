namespace LocalBusinessDirectory.Data.Sql;

public interface ISqlAccess
{
    Task ExecuteAsync(string storedProcedure, object parameters);
    Task<List<T>> GetAsync<T>(string storedProcedure, object parameters);
    Task<List<T>> GetAsync<T, TFirst, TSecond>(string storedProcedure, object parameters, Func<TFirst, TSecond, T> map);
    Task<T> GetFirstOrDefaultAsync<T>(string storedProcedure, object parameters);
}