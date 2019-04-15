using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

    /// <summary>
    /// A class used for generating bank card information.
    /// </summary>
    public class CardGenerator
    {

        /// <summary>
        /// This method takes in a string representation of a card PIN and returns an MD5 has of it.
        /// </summary>
        /// <param name="password">string representation of a card PIN code</param>
        /// <returns>MD5 has of the PIN code</returns>
        public string HashPin(string password)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// This method generates a random 16-digit sequence which serves as the cards ID number.
        /// </summary>
        /// <returns>string representation of a bank card ID</returns>
        public string GenerateCardNumber()
        {
            StringBuilder sb = new StringBuilder();
            Random r = new Random();

            for (int i = 0; i < 4; i++)
            {
                sb.Append(r.Next(1000, 9999));
            }
            return sb.ToString();
        }
    }
}
