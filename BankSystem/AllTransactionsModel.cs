using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class AllTransactionsModel
    {
        public DataSet GetAllTransactions(string accountID)
        {
            return new TransactionRepository().GetTransactions(accountID);
        }

        public DataSet GetAllTransactions()
        {
            return new TransactionRepository().GetTransactions();
        }

        public DataSet GetFilteredTransactions(List<string> filterCriteria)
        {
            return new TransactionRepository().GetFilteredTransactions(filterCriteria);
        }

    }
}
