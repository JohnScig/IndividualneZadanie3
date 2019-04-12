using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformerBank
{
    public class WithdrawModel
    {
        public bool Withdraw(decimal amount, string cardNumber)
        {
            return new CardRepository().Withdraw(amount,cardNumber);
            //return false;
        }
        
    }
}
