using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class AdjustDebitModel
    {
        public bool AdjustDebit(string iban, decimal newDebitLimit)
        {
            return new AccountRepository().AdjustDebit(iban, newDebitLimit);
        }
    }
}
