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
    }
}
