using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{

    /// <summary>
    /// Class for generating bank accounts.
    /// </summary>
    public class AccountGenerator
    {
        /// <summary>
        /// Generates an Account Model and sets its IBAN code, Bank ID and sets its opening date as current date & time.
        /// </summary>
        /// <returns>An AccountModel object</returns>
        public AccountModel GenerateAccount()
        {
            AccountModel accountModel = new AccountModel() {IBAN = IbanGenerator(),BankID="9999",OpenDate=DateTime.Now};

            return accountModel;
        }

        /// <summary>
        /// Generates a new IBAN in Slovak format. The bank code is set for 9999 for testing purposes.
        /// </summary>
        /// <returns>A string representation of an IBAN code</returns>
        public string IbanGenerator()
        {
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            sb.Append("SK");
            sb.Append(r.Next(10, 99).ToString());
            sb.Append("9999");
            sb.Append("000000");
            sb.Append(r.Next(10000, 99999).ToString());
            sb.Append(r.Next(10000, 99999).ToString());

            return sb.ToString();
        }
    }
}
