namespace LocalBusinessDirectory.Helpers;

public interface IDataPersist
{
    void Persist(string key, object value);
    T? Pop<T>(string key);
}