using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class DepositModel
    {
        public bool Deposit(decimal amount, string currentAccountID)
        {
            return new AccountRepository().Deposit(amount, currentAccountID);
        }
    }
}
