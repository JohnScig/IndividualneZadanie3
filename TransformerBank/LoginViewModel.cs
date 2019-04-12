using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controls;
using System.Security.Cryptography;

namespace TransformerBank
{
    public class LoginViewModel
    {
        public bool CheckLoginInfo(string cardNumber, string pin)
        {
            CardRepository cardRepository = new CardRepository();
            return cardRepository.CheckCard(cardNumber,HashPin(pin));
        }

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
    }
}
