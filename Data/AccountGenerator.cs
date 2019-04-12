using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class AccountGenerator
    {
        public AccountModel GenerateAccount()
        {
            AccountModel accountModel = new AccountModel() {IBAN = IbanGenerator(),BankID="9999",OpenDate=DateTime.Now};

            return accountModel;
        }

        public string IbanGenerator()
        {
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            sb.Append("SK");
            sb.Append(r.Next(10, 99).ToString());
            sb.Append("000000");
            sb.Append(r.Next(10000, 99999).ToString());
            sb.Append(r.Next(10000, 99999).ToString());

            return sb.ToString();
        }
    }
}
