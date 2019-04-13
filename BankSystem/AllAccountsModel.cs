using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class AllAccountsModel
    {
        public DataSet GetAllAccounts()
        {
            return new AccountRepository().GetAllAccounts();
        }
    }
}
