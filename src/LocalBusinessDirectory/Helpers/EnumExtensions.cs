using System.Text.RegularExpressions;

namespace LocalBusinessDirectory.Helpers;

public static partial class EnumExtensions
{
    public static string ToFormattedString(this Enum value)
    {
        return PascalCaseHumanizer().Replace(value.ToString(), m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");
    }

    [GeneratedRegex("[a-z][A-Z]")]
    private static partial Regex PascalCaseHumanizer();
}