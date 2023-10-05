using static BCrypt.Net.BCrypt;

namespace LocalBusinessDirectory.Data.Helpers;
public class PasswordHasher : IPasswordHasher
{
    public string HashPassword(string password)
    {
        return EnhancedHashPassword(password);
    }

    public bool VerifyPassword(string password, string hash)
    {
        return EnhancedVerify(password, hash);
    }
}
