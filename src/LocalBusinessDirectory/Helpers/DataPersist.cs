namespace LocalBusinessDirectory.Helpers;

public class DataPersist : IDataPersist
{
    private readonly Dictionary<string, object> _cache = new();

    public void Persist(string key, object value)
    {
        _cache.Add(key, value);
    }

    public T? Pop<T>(string key)
    {
        if (_cache.TryGetValue(key, out var value))
        {
            _cache.Remove(key);
            return (T?)value;
        }
        return default;
    }
}
