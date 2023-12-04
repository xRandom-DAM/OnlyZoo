using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZoo.util
{
    public class PasswordEncrypter
    {
        public static string Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convierte el string a un array de bytes
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);

                // Calcula el hash
                byte[] hashBytes = sha256.ComputeHash(inputBytes);

                // Convierte el hash a una cadena hexadecimal
                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}
