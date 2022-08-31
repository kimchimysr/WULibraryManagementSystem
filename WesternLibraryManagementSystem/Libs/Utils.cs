using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WesternLibraryManagement.Libs
{
    public static class Utils
    {
        public static bool FormIsOpen(string form)
        {
            // check if window has already open
            var OpenForms = Application.OpenForms.Cast<Form>();

            return OpenForms.Any(x => x.Name == form);
        }

        public static string HashPassword(string password)
        {
            SHA256 sha = SHA256.Create();

            // convert the input string to a byte array and compute the hash
            byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(password));

            // create a new stringBuilder to collect the bytes
            // and create a string
            StringBuilder sb = new StringBuilder();

            // loop through each byte of the hashed data
            // and format each one as a hexadecimal string
            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }

        public static string DefaultHashPassword()
        {
            return HashPassword("Password@123");
        }
    }
}
