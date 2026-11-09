using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace Inventory
{
    internal class PasswordHelper
    {
        public static bool VerifyPassword(string password, string storedHash)
        {
            try
            {
                string[] parts = storedHash.Split('$');

                if (parts.Length != 4 || parts[0] != "PDKDF2")
                    return false;

                int iterations = int.Parse(parts[1]);
                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] originalHash = Convert.FromBase64String(parts[3]);

                using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
                {
                    byte[] newHash = pbkdf2.GetBytes(32);

                    if(newHash.Length != originalHash.Length)
                        return false;

                    int difference = 0;

                    for (int i = 0; i < newHash.Length; i++)
                    {
                        difference |= newHash[i] ^ originalHash[i];
                    }

                    return difference == 0;
                }

            }
            catch
            {
                return false;
            }
        }

        public static string HashPassword(string password)
        {
            byte[] salt = new byte[16];

            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            const int iterations = 10000;

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations))
            {
                byte[] hash = pbkdf2.GetBytes(32);
                string storedHash = $"PDKDF2${iterations}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
                return storedHash;
            }
        }
    }
}
