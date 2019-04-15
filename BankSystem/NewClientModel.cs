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
    public class NewClientModel
    {
        private ClientModel _clientModel = new ClientModel();

        private AccountModel _accountModel = new AccountModel();

        public ClientModel GenerateRandomClient()
        {
            return new ClientGenerator().GeneratePerson();
        }

        public bool CreateClientAndAccount(ClientModel clientModel)
        {
            //AccountModel accountModel = new AccountGenerator().GenerateAccount();

            int clientID = new ClientRepository().AddClient(clientModel);
            if (clientID > 0)
            {
                if (new AccountRepository().AddAccount(new AccountGenerator().GenerateAccount(), clientID))
                {
                    return true;
                }
                
            }
            return false;
        }

        public ClientModel GetClient(string personalID)
        {
            return new ClientRepository().GetClient(personalID);
        }

        public bool EditClient(string personalID, ClientModel currentClient)
        {
            return new ClientRepository().EditClient(personalID, currentClient);
        }
    }
}
