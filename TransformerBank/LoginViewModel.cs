using Data.Repositories;
using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controls;
using System.Security.Cryptography;

namespace TransformerBank
{
    public class LoginViewModel
    {
        public bool CheckLoginInfo(string cardNumber, string pin)
        {
            CardRepository cardRepository = new CardRepository();
            return cardRepository.CheckCard(cardNumber,new CardGenerator().HashPin(pin));
        }

        public bool CheckBlockedCard(string cardNumber)
        {
            return new CardRepository().CheckBlockedCard(cardNumber);
        }

        public int CheckTries(string cardNumber)
        {
            int tries = new CardRepository().CheckTries(cardNumber);
            
            if (tries > 4)
            {
                new CardRepository().BlockCard(cardNumber);
                return tries;
            }

            return tries;

        }

        public void RemoveOldPinMistakes(string cardNumber)
        {
            new CardRepository().RemoveOldPinMistakes(cardNumber);
        }

    }
}
