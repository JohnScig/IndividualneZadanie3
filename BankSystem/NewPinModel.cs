using Data;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    class NewPinModel
    {
        public bool AddCard(string newPin, string accountID)
        {

            return new CardRepository().AddCard(new CardGenerator().GenerateCardNumber(), new CardGenerator().HashPin(newPin), newPin, accountID);
            //return false;
        }

        public bool NewPin(string newPin, string cardNumber)
        {
            return new CardRepository().SetNewPin(cardNumber,new CardGenerator().HashPin(newPin) ,newPin);
        }
    }
}
