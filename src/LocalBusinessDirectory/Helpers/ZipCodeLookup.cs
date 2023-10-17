using System.Text.Json;
using System.Text.Json.Serialization;

namespace LocalBusinessDirectory.Helpers;

public class ZipCodeLookup : IZipCodeLookup
{
#nullable disable
    public class ZipCode
    {
        [JsonPropertyName("z")]
        public string Zip { get; set; }
        [JsonPropertyName("o")]
        public double Longitude { get; set; }
        [JsonPropertyName("a")]
        public double Latitude { get; set; }
    }
#nullable enable

    public ZipCodeLookup(IHostEnvironment env)
    {
        _env = env;
    }

    private List<ZipCode>? _zipCodes;
    private ILookup<char, ZipCode>? _grouping;
    private readonly IHostEnvironment _env;

    public async Task<ILookup<char, ZipCode>> Load()
    {
        if (_zipCodes is null)
        {
            using var fs = File.Open(Path.Combine(_env.ContentRootPath, "ZipCodes.json"), FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            _zipCodes = await JsonSerializer.DeserializeAsync<List<ZipCode>>(fs);
            _grouping = _zipCodes!.ToLookup(x => x.Zip[0]);
        }

        return _grouping!;
    }
}
