using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class WithdrawModel
    {
        public bool Withdraw(decimal amount, string currentAccountID)
        {
            return new AccountRepository().Withdraw(amount, currentAccountID);
        }
    }
}
