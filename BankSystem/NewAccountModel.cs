using Data;
using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class NewAccountModel
    {

        public ClientModel GenerateRandomClient()
        {
            return new ClientGenerator().GeneratePerson();
        }

        public bool CreateClientAndAccount(ClientModel clientModel)
        {
            AccountModel accountModel = new AccountGenerator().GenerateAccount();

            int clientID = new ClientRepository().AddClient(clientModel);
            if (clientID > 0)
            {
                if (new AccountRepository().AddAccount(accountModel, clientID))
                {
                    return true;
                }
                
            }
            return false;
        }


    }
}
