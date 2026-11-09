using System.Security.Cryptography;

namespace scholarship_Application.Data
{
    public static class PasswordHasher
    {
        private const int Iterations = 100_000;
        private const int SaltSize = 16;
        private const int HashSize = 32;

        public static (string salt, string hash) Hash(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, Iterations, HashAlgorithmName.SHA256, HashSize);
            return (Convert.ToBase64String(salt), Convert.ToBase64String(hash));
        }

        public static bool Verify(string password, string salt, string hash)
        {
            byte[] expected = Convert.FromBase64String(hash);
            byte[] actual = Rfc2898DeriveBytes.Pbkdf2(
                password, Convert.FromBase64String(salt), Iterations, HashAlgorithmName.SHA256, HashSize);
            return CryptographicOperations.FixedTimeEquals(actual, expected);
        }
    }
}
