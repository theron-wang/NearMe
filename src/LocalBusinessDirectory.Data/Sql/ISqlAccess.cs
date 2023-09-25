namespace LocalBusinessDirectory.Data.Sql;

public interface ISqlAccess
{
    Task ExecuteAsync(string storedProcedure, object parameters);
    Task<List<T>> GetAsync<T>(string storedProcedure, object parameters);
    Task<T> GetFirstOrDefaultAsync<T>(string storedProcedure, object parameters);
}