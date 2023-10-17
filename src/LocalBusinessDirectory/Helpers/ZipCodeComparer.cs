using static LocalBusinessDirectory.Helpers.ZipCodeLookup;

namespace LocalBusinessDirectory.Helpers;

public class ZipCodeComparer : IComparer<string>
{
    private readonly double _latitude;
    private readonly double _longitude;
    private readonly ILookup<char, ZipCode> _lookup;

    public ZipCodeComparer(ILookup<char, ZipCode> lookup, double latitude, double longitude)
    {
        _lookup = lookup;
        _latitude = latitude;
        _longitude = longitude;
    }

    public int Compare(string? zip1, string? zip2)
    {
        var zip1Object = _lookup[zip1![0]].First(z => z.Zip == zip1);
        var zip2Object = _lookup[zip2![0]].First(z => z.Zip == zip2);

        double distance1 = CalculateHaversineDistance(_latitude, _longitude, zip1Object.Latitude, zip1Object.Longitude);
        double distance2 = CalculateHaversineDistance(_latitude, _longitude, zip2Object.Latitude, zip2Object.Longitude);

        return distance1.CompareTo(distance2);
    }

    private static double CalculateHaversineDistance(double lat1, double lon1, double lat2, double lon2)
    {
        const double earthRadius = 6371;

        // https://community.esri.com/t5/coordinate-reference-systems-blog/distance-on-a-sphere-the-haversine-formula/ba-p/902128

        lat1 *= Math.PI / 180;
        lat2 *= Math.PI / 180;

        var a = Math.Pow(Math.Sin((lat2 - lat1) / 2), 2) +
            Math.Cos(lat1) * Math.Cos(lat2) *
            Math.Pow(Math.Sin((lon2 - lon1) / 2), 2);

        var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        return earthRadius * c;
    }
}
