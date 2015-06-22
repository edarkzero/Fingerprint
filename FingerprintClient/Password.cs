using System;
using System.Globalization;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;

namespace Fingerprint.Password
{
    static class Password
    {
        private static int SaltValueSize = 11;
        private static string HashType = "SHA256";
        private static string SaltDefault = "123asd"; //La sal puede ser el mismo nombre del usuario o se usa el Generador de sal y se guarda en la base de datos

        public static string GenerateHashWithSalt(string password)
        {
            // merge password and salt together
            string sHashWithSalt = password + SaltDefault;
            // convert this merged value to a byte array
            byte[] saltedHashBytes = Encoding.UTF8.GetBytes(sHashWithSalt);
            // use hash algorithm to compute the hash
            System.Security.Cryptography.HashAlgorithm algorithm = new System.Security.Cryptography.SHA256Managed();
            // convert merged bytes to a hash as byte array
            byte[] hash = algorithm.ComputeHash(saltedHashBytes);
            // return the has as a base 64 encoded string
            return Convert.ToBase64String(hash);
        }

        public static bool VerifyHashWithSalt(string password,string storedPassword)
        {
            string passwordHashed = GenerateHashWithSalt(password);
            return passwordHashed == storedPassword;
        }

        private static string GenerateSaltValue()
        {
            UnicodeEncoding utf16 = new UnicodeEncoding();

            if (utf16 != null)
            {
                // Create a random number object seeded from the value
                // of the last random seed value. This is done
                // interlocked because it is a static value and we want
                // it to roll forward safely.

                Random random = new Random(unchecked((int)DateTime.Now.Ticks));

                if (random != null)
                {
                    // Create an array of random values.

                    byte[] saltValue = new byte[Password.SaltValueSize];

                    random.NextBytes(saltValue);

                    // Convert the salt value to a string. Note that the resulting string
                    // will still be an array of binary values and not a printable string. 
                    // Also it does not convert each byte to a double byte.

                    string saltValueString = utf16.GetString(saltValue);

                    // Return the salt value as a string.

                    return saltValueString;
                }
            }

            return null;
        }

    }
}
