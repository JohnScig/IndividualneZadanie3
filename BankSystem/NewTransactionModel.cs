using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class NewTransactionModel
    {
        public bool TransferMoney(string senderIBAN, string receiverIBAN, decimal amount, string variable, string specific, string constant, string message)
        {
            return (AccountRepository.TransferMoney(senderIBAN, receiverIBAN, amount, variable, specific, constant, message));
        }
    }
}
