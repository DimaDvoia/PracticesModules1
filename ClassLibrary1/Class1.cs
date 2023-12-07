using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ClassLibrary1
{
    public class Class1
    {
        public static string HashPassword1(string password) 
        {
            using (SHA256 sha256Hash = SHA256.Create()) 
            {
                byte[] sourceBytePassw = Encoding.UTF8.GetBytes(password);
                byte[] hashSourceBytePassw = sha256Hash.ComputeHash(sourceBytePassw);
                string hashPassw = BitConverter.ToString(hashSourceBytePassw).Replace("_", String.Empty);
                return hashPassw;
            }
        }
    }

}
