using Data;
using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class ClientManagerModel
    {
        public List<string> GetClientAndAccountInfo(string personalID)
        {
            List<string> basicClientInfo = new List<string>();

            foreach (string information in new ClientRepository().GetBasicInfo(personalID))
            {
                basicClientInfo.Add(information);
            }

            foreach (string information in new AccountRepository().GetBasicInfo(basicClientInfo[0]))
            {
                basicClientInfo.Add(information);
            }

            return basicClientInfo;
        }

        public DataSet GetCardInfo(string iban)
        {
            return new CardRepository().GetCards(iban);
        }

        public bool BlockCard(string cardNumber)
        {
            return new CardRepository().BlockCard(cardNumber);
        }

        public bool UnblockCard(string cardNumber)
        {
            return new CardRepository().UnblockCard(cardNumber);
        }

        public List<string> GetClientInfo(string personalID)
        {
            List<string> basicClientInfo = new List<string>();

            foreach (string information in new ClientRepository().GetBasicInfo(personalID))
            {
                basicClientInfo.Add(information);
            }
            return basicClientInfo;

        }

        public List<AccountModel> GetAccounts(string personalID)
        {
            return new AccountRepository().GetAllAccounts(personalID);
        }

        public bool OpenNewAccount(string personalID)
        {
            return new AccountRepository().AddAccount(new AccountGenerator().GenerateAccount(), personalID);
        }

        public bool CloseAccount(string iban)
        {
            return (new CardRepository().BlockAllCards(iban) && new AccountRepository().CloseAccount(iban));
        }
    }
}
