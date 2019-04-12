using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformerBank
{
    public class MainMenuModel
    {
        public decimal CheckBalance(string cardNumber)
        {
            return new CardRepository().CheckBalance(cardNumber);
        }
    }
}
