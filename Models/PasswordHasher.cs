using System;
using System.Security.Cryptography;

public class PasswordHasher
{
    public static string HashPassword(string password)
    {
        byte[] salt = new byte[16];
        using (var rng = RandomNumberGenerator.Create())
        {
            rng.GetBytes(salt);
        }

        using (var rfc2898 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256))
        {
            byte[] hash = rfc2898.GetBytes(32);
            byte[] hashBytes = new byte[48];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 32);
            return Convert.ToBase64String(hashBytes);
        }
    }
}
