using System.Security.Cryptography;

namespace SariScan;

public static class PasswordHasher
{
    private const int Iterations = 100_000;

    public static (byte[] Hash, byte[] Salt) Hash(string password)
    {
        var salt = RandomNumberGenerator.GetBytes(16);
        var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32);
        return (hash, salt);
    }

    public static bool Verify(string password, byte[] salt, byte[] expectedHash)
    {
        var hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, 32);
        return CryptographicOperations.FixedTimeEquals(hash, expectedHash);
    }
}
